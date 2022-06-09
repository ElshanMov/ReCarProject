using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarManagerTest();
            //ColorManagerTest();
            //UserManagerTest();
            //CustomerManagerTest();
            //RentalManager();
        }

        private static void RentalManager()
        {
            RentalManager rental = new RentalManager(new EfRentalDal());
            var result = rental.Add(new Rental
            {
                CarId = 1,
                CustomerId = 1,
                RentDate = DateTime.Parse("2022-04-17"),
                ReturnDate = DateTime.Parse("2022-04-18")
            });
            Console.WriteLine(result.Message);
        }

        private static void CarManagerTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.Add(new Car
            {
                BrandId = 1,
                ColorId = 2,
                DailyPrice = 100,
                Description = "Lithium ion battery",
                Model = "Model S",
                ModelYear = DateTime.Parse("07-07-2002")
            });
            Console.WriteLine(result.Message);
        }

        private static void ColorManagerTest()
        {
            ColorManager colorManager = new ColorManager(new EfColorDal());
            colorManager.Add(new Color
            {
                Name = "Gray",
                Code = "#808080"
            });

            colorManager.GetAll().Data.ForEach(x => Console.WriteLine(x.Name));
        }

        private static void CustomerManagerTest()
        {
            CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
            customerManager.Add(new Customer
            {
                Id = 1,
                UserId = 1,
                CompanyName = "DSTLD"
            });
            customerManager.Add(new Customer
            {
                Id = 2,
                UserId = 2,
                CompanyName = "Madeyra"
            });
            customerManager.Add(new Customer
            {
                Id = 3,
                UserId = 3,
                CompanyName = "SIS"
            });

            customerManager.GetAll().Data.ForEach(x => Console.WriteLine(x.CompanyName));
        }

        //private static void UserManagerTest()
        //{
        //    UserManager userManager = new UserManager(new EfUserDal());

        //    userManager.Add(new User
        //    {
        //        Id = 1,
        //        FirstName = "Ali",
        //        LastName = "Yusifov",
        //        Email = "Ali.2002@mail.ru",
        //        Password = "Rental.P201",
        //    });
        //    userManager.Add(new User
        //    {
        //        Id = 2,
        //        FirstName = "Isa",
        //        LastName = "Heyderov",
        //        Email = "Isa.2002@mail.ru",
        //        Password = "Rental.P201",
        //    });
        //    userManager.Add(new User
        //    {
        //        Id = 3,
        //        FirstName = "Subkan",
        //        LastName = "Ramazanov",
        //        Email = "Subkhan.2002@mail.ru",
        //        Password = "Rental.P201",
        //    });

        //    var result = userManager.GetAll();
        //    if (result.Success)
        //    {
        //        foreach (var user in result.Data)
        //        {
        //            Console.WriteLine(user.FirstName + " " + user.LastName);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }
        //}
    }
}
