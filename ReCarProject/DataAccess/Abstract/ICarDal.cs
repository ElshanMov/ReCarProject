using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    //Car`la elaqedar DB`da edeceyim prosesleri ehate eden interface
    public interface ICarDal:IEntityRepository<Car>
    {
        
    }
}
