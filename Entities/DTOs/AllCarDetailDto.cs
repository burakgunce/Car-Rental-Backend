using Core.Entities;

namespace Entities.DTOs
{
    public class AllCarDetailDto : IDto
    {
        public int Id { get; set; }
        public int ModelColorId { get; set; }
        public int ModelId { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public string ColorName { get; set; }
        public short ModelYear { get; set; }
        public double DailyPrice { get; set; }
        public string Description { get; set; }
        public List<string> ImagePath { get; set; }
    }
}
