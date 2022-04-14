using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Rental : IEntity
    {
        //CRUD operasyonlarını yazınız.
        //Yeni müşteriler ekleyiniz.
        //Arabayı kiralama imkanını kodlayınız.Rental-->Add
        //Arabanın kiralanabilmesi için arabanın teslim edilmesi gerekmektedir.
        public int Id { get; set; }
        public int CarId { get; set; }
        public int CustomerId { get; set; }
        public DateTime RentDate { get; set; }
        public DateTime? ReturnDate { get; set; } = null;
    }
}
