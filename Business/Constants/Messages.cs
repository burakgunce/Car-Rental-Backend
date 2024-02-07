using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string UserRegistered = "User registered successfully.";
        public static string UserNotFound = "User not found.";
        public static string AccessTokenCreated = "Access token created successfully.";
        public static string PasswordError = "Password error.";
        public static string SuccessfulLogin = "Login successful.";
        public static string UserAlreadyExists = "User already exists.";
        public static string BrandCreated = "Brand created successfully.";
        public static string BrandDeleted = "Brand deleted successfully.";
        public static string BrandUpdated = "Brand updated successfully.";
        public static string CarAdded = "Car added successfully.";
        public static string CarDeleted = "Car deleted successfully.";
        public static string CarsListed = "Cars listed successfully.";
        public static string CarUpdated = "Car updated successfully.";
        public static string ColorCreated = "Color created successfully.";
        public static string ColorDeleted = "Color deleted successfully.";
        public static string ColorUpdated = "Color updated successfully.";
        public static string ModelCreated = "Model created successfully.";
        public static string ModelDeleted = "Model deleted successfully.";
        public static string ModelUpdated = "Model updated successfully.";
        public static string RentalCreated = "Rental created successfully.";
        public static string RentalDeleted = "Rental deleted successfully.";
        public static string RentalUpdated = "Rental updated successfully.";
        public static string CarImageLimitExceeded = "You can not upload image over 15 piece.";
        public static string CarImageCreated = "Car Image added.";
        internal static string CarImageDeleted;
        internal static string CarImageUpdated;
    }
}
