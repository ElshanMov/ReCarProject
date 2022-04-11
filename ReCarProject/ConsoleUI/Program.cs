using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());

            brandManager.Add(new Brand
            {
                Name = "Renault"
            });

            foreach (var item in brandManager.GetAll())
            {
                Console.WriteLine(item.Name);
            }
            
        }
    }
}
