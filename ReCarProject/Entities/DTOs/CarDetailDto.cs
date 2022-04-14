﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public string CarModel { get; set; }
        public string BrandName { get; set; }
        public string Color { get; set; }
        public decimal DailyPrice { get; set; }

    }
}
