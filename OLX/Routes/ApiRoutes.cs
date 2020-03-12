using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OLX.Routes
{
    public static class ApiRoutes
    {
        public const string Root = "api";
        public const string Version = "v1";
        public const string Base = Root + "/" + Version;


        public static class Posts
        {
           
            public const string Get = Base + "/Adverts/{AdvertId}";
            public const string PostAdvert = Base + "/Create";
            public const string GetAdverts = Base + "/Adverts";
            public const string DeleteAdvert = Base + "/Advert/{AdvertId}";
            public const string UpdateAdvert = Base + "/Advert/{AdvertId}";
        }

    }
}
