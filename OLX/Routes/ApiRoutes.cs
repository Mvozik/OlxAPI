using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Routes
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string version = "v1";
        public const string Base = Root + "/" + version;


        public static class Adverts
        {

            public const string Get = Base + "/Adverts/{AdvertId}";
            public const string PostAdvert = Base + "/CreateAdvert";
            public const string GetAdverts = Base + "/Adverts";
            public const string DeleteAdvert = Base + "/Advert/{AdvertId}";
            public const string UpdateAdvert = Base + "/Advert/{AdvertId}";
        }
        public static class Categories
        {
            public const string Get = Base + "/Category/{CategoryId}";
            public const string PostCategory = Base + "/CreateCategory";
            public const string GetCategories = Base + "/Categories";
            public const string DeleteCategory = Base + "/Category/{CategoryId}";
            public const string UpdateCategory = Base + "/Category/{CategoryId}";
        }
        public static class SubCategories
        {
            public const string Get = Base + "/SubCategory/{SubCategoryId}";
            public const string PostSubCategory = Base + "/CreateSubCategory";
            public const string GetSubCategories = Base + "/SubCategories";
            public const string DeleteSubCategory = Base + "/SubCategory/{SubCategoryId}";
            public const string UpdateSubCategory = Base + "/SubCategory/{SubCategoryId}";
        }
        public static class Message
        {
            public const string Get = Base + "/Message/{MessageId}";
            public const string PostMessage = Base + "/CreateMessage";
            public const string GetMessages = Base + "/Messages";
            public const string DeleteMessage = Base + "/Message/{MessageId}";
            public const string UpdateMessage = Base + "/Message/{MessageId}";
        }

        public static class User
        {
            public const string RegisterUser = Base + "/Register";
            public const string DeleteUser = Base + "/Delete/{UserId}";
            
        }


    }
}
