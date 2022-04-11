using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class CarColor:IEntity
    {
        public int Id { get; set; }
        public int CarId { get; set; }
        public int ColorId { get; set; }
        public Car Car { get; set; }
        public Color Color { get; set; }
    }
}
