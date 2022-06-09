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
using System.Text;

namespace Business.Concrete
{
    public class CarImageManager : ICarImageService
    {
        ICarImageDal _carImageDal;

        public CarImageManager(ICarImageDal carImageDal)
        {
            _carImageDal = carImageDal;
        }

        public IResult Add(IFormFile imageFile, CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageNull(imageFile), CheckIfCarImageFormat(imageFile),
                CheckIfCarImageMaxSize(imageFile), CheckIfCarImageCount(carImage.CarId));
            if (result != null)
            {
                return result;
            }
            carImage.ImagePath = FileManager.Save(PathConstant.ImagePath(), "uploads/images", imageFile).Data;
            carImage.Date = DateTime.UtcNow.AddHours(4);
            _carImageDal.Add(carImage);
            return new SuccessResult("Database e sekil elave olundu");
        }

        public IResult Delete(CarImage carImage)
        {
            FileManager.Delete(PathConstant.ImagePath(), "uploads/images", carImage.ImagePath);
            _carImageDal.Delete(carImage);
            return new SuccessResult();
        }

        public IDataResult<List<string>> GetAllByCarIdImage(int carId)
        {
            List<string> photo = new List<string>() {"default.png"}; //refactor
            var result=_carImageDal.GetAll(x => x.CarId == carId);
            if (result==null)
            {
                return new ErrorDataResult<List<string>>(photo);
            }
            result.ForEach(x => photo.Add(x.ImagePath));
            return new SuccessDataResult<List<string>>(photo);
        }

        public IResult Update(IFormFile imageFile,CarImage carImage)
        {
            var result = BusinessRules.Run(CheckIfCarImageNull(imageFile),
                FileManager.Delete(PathConstant.ImagePath(),"uploads/images",carImage.ImagePath), CheckIfCarImageFormat(imageFile),
                CheckIfCarImageMaxSize(imageFile), CheckIfCarImageCount(carImage.CarId));
            if (result != null)
            {
                return result;
            }          
            carImage.ImagePath = FileManager.Save(PathConstant.ImagePath(), "uploads/images", imageFile).Data;
            carImage.Date = DateTime.UtcNow.AddHours(4);
            _carImageDal.Update(carImage);
            return new SuccessResult("Shekil editlendi");
        }

        private IResult CheckIfCarImageNull(IFormFile imageFile)
        {
            if (imageFile == null)
            {
                return new ErrorResult(Messages.CarImageisNull);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageFormat(IFormFile imageFile)
        {
            if (imageFile.ContentType != "image/jpeg" || imageFile.ContentType != "image/png"
                || imageFile.ContentType != "image/svg" || imageFile.ContentType != "image/gif")
            {
                return new ErrorResult(Messages.CarImageFormatInCorrect);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageMaxSize(IFormFile imageFile)
        {
            if (imageFile.Length > 2097152)
            {
                return new ErrorResult(Messages.CarImageSizeInvalid);
            }
            return new SuccessResult();
        }

        private IResult CheckIfCarImageCount(int carId)
        {
            var result = _carImageDal.GetAll(x => x.CarId == carId).Count;
            if (result > 5)
            {
                return new ErrorResult(Messages.CarImageCountInCorrect);
            }
            return new SuccessResult();
        }

        
    }
}
