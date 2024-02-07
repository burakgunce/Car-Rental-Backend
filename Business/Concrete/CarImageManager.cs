using Business.Abstract;
using Business.Constants;
using Core.Utilities.Business;
using Core.Utilities.Helpers;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile file, CarImage carImage)
        {
            var businessResult = BusinessRules.Run(CheckIfCarImageLimitExceeded(carImage.Id));

            if (businessResult != null)
            {
                return businessResult;
            }

            var imageResult = FileHelper.Upload(file);

            if (!imageResult.Success)
            {
                return imageResult;
            }

            carImage.ImagePath = imageResult.Message;
            carImage.Date = DateTime.Now;

            _carImageDal.Add(carImage);
            return new SuccessResult(Messages.CarImageCreated);
        }

        public IResult Delete(CarImage carImage)
        {
            var result = FileHelper.Delete(carImage.ImagePath);

            if (!result.Success)
            {
                return new ErrorResult();
            }

            _carImageDal.Delete(carImage);
            return new SuccessResult(Messages.CarImageDeleted);
        }

        public IDataResult<List<CarImage>> GetAll()
        {
            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll());
        }

        public IDataResult<List<CarImage>> GetAllByCarId(int carId)
        {
            var result = BusinessRules.Run();

            //if (result != null)
            //{
            //    switch (result.Message)
            //    {
            //        case :Messages.CarImageNotExist:
            //            return SetDefaultPhoto(carId);

            //        default:
            //            return new ErrorDataResult<List<CarImage>>(result.Message);
            //    }
            //}

            return new SuccessDataResult<List<CarImage>>(_carImageDal.GetAll(c => c.CarId == carId));
        }

        public IDataResult<CarImage> GetById(int id)
        {
            return new SuccessDataResult<CarImage>(_carImageDal.Get(c => c.Id == id));
        }

        public IResult Update(IFormFile file, CarImage carImage)
        {
            var result = BusinessRules.Run();

            if (result != null)
            {
                return result;
            }

            var imageResult = FileHelper.Update(file, carImage.ImagePath);

            if (!imageResult.Success)
            {
                return imageResult;
            }

            carImage.ImagePath = imageResult.Message;
            carImage.Date = DateTime.Now;

            _carImageDal.Update(carImage);
            return new SuccessResult(Messages.CarImageUpdated);
        }

        ///////////////////////////////////////// BUSINESS RULES /////////////////////////////////////////////
        
        private IResult CheckIfCarImageLimitExceeded(int carId)
        {
            var result = _carImageDal.GetAll(c => c.CarId == carId).Count();

            if (result > 15)
            {
                return new ErrorResult(Messages.CarImageLimitExceeded);
            }

            return new SuccessResult();
        }

        private static IDataResult<List<CarImage>> SetDefaultPhoto(int carId)
        {
            return new SuccessDataResult<List<CarImage>>(new List<CarImage>{new CarImage
            {
                CarId = carId,
                Date = DateTime.Now,
                ImagePath = @"/Images/default.png"
            }});
        }
    }
}
