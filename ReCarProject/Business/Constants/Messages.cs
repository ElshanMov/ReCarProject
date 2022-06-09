using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        //It should be refactored.

        //Car
        public static string CarAdded = "Adding car is successful";
        public static string CarAddFail = "Add car failed";

        //User
        public static string UserAdded = "Adding user is successful";
        public static string UserAddFail = "Add user failed";

        //Customer
        public static string CustomerAdded = "Adding customer is successful";
        public static string CustomerAddFail = "Add customer failed";

        //Rental
        public static string RentalProcess = "Rental process is successful";
        public static string RentalProcessFail = "Rental process failed";


        //Generic Messages
        public static string Maintenance = "System is in maintenance";

        //CarImage
        public static string CarImageisNull = "Car image is null";
        public static string CarImageFormatInCorrect = "The car's image format is invalid";
        public static string CarImageSizeInvalid = "Car photo size should be maximum 2 mb";
        public static string CarImageCountInCorrect = "The number of car pictures should be a maximum of 5";

        //Authorization
        public static string UserNotFound = "User not found";
        public static string PasswordError = "Password is incorrect";
        public static string SuccessfulLogin = "Login successful";
        public static string UserRegistered = "Register process is successful";
        public static string UserAlreadyExists = "User already exists";
        public static string AccessTokenCreated = "Access token created";
        public static string AuthorizationDenied = "Authorization denied";
    }
}
