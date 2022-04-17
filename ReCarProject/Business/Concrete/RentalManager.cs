using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Business.Concrete
{
    public class RentalManager : IRentalService
    {
        IRentalDal _rentalDal;

        public RentalManager(IRentalDal rentalDal)
        {
            _rentalDal = rentalDal;
        }

        public IResult Add(Rental rental)
        {
            Rental existRental = _rentalDal.Get(x=>x.Id==rental.Id);
            if (existRental != null && existRental.ReturnDate==DateTime.Now) //Refactor olunmalidir(yanlish yazilib).
            {
                return new ErrorResult("The car you want to rent is currently rented.");
            }
            _rentalDal.Add(rental);
            return new SuccessResult(Messages.RentalProcess);
        }

        public IResult Delete(Rental rental)
        {
            throw new NotImplementedException();
        }

        public IDataResult<Rental> Get()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Rental>> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
