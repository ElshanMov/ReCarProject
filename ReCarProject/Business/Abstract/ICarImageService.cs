using Core.Utilities.Results;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImageService
    {
        IResult Add(IFormFile imageFile,CarImage carImage);
        IResult Update(IFormFile imageFile,CarImage carImage);
        IResult Delete(CarImage carImage);
        IDataResult<List<string>> GetAllByCarIdImage(int carId);



    }
}
