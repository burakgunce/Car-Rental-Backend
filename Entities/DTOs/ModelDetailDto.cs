﻿using Core.Entities;

namespace Entities.DTOs
{
    public class ModelDetailDto : IDto
    {
        public int Id { get; set; }
        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Name { get; set; }
        public short Year { get; set; }
    }
}
