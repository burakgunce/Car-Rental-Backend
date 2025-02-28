﻿using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Caching;
using Core.Aspects.Autofac.Transaction;
using Core.Aspects.Autofac.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        [ValidationAspect(typeof(RentalValidator))]
        [TransactionScopeAspect]
        [CacheRemoveAspect("GetAll")]
        public IResult Add(Rental rental)
        {
            var result = BusinessRules.Run(CheckIfCarHasBeenReturned(rental.CarId));

            if (result != null)
            {
                return result;
            }

            _rentalDal.Add(rental);

            return new SuccessResult(Messages.RentalCreated);
        }

        [TransactionScopeAspect]
        public IResult Delete(Rental rental)
        {
            _rentalDal.Delete(rental);
            return new SuccessResult(Messages.RentalDeleted);
        }

        [CacheAspect]
        public IDataResult<List<Rental>> GetAll()
        {
            return new SuccessDataResult<List<Rental>>(_rentalDal.GetAll());
        }

        public IDataResult<Rental> GetById(int id)
        {
            return new SuccessDataResult<Rental>(_rentalDal.Get(b => b.RentalId == id));
        }

        [ValidationAspect(typeof(RentalValidator))]
        [TransactionScopeAspect]
        public IResult Update(Rental rental)
        {
            _rentalDal.Update(rental);
            return new SuccessResult(Messages.RentalUpdated);
        }

        ////////////////////////////////BUSINESS RULES//////////////////////////////

        private IResult CheckIfCarHasBeenReturned(int id)
        {
            var result = _rentalDal.GetAll(r => r.CarId == id);

            foreach (var car in result)
            {
                if (car.ReturnDate == DateTime.MinValue || car.ReturnDate > DateTime.Now)
                {
                    return new ErrorResult();
                }
            }

            return new SuccessResult();
        }
    }
}
