using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.API.Helpers
{
    public static class Extensions
    {
        public static void AddApplicationError(this HttpResponse resposne, string message)
        {
            resposne.Headers.Add("Application-Error", message);
            resposne.Headers.Add("Access-Control-Expose-Headers", "Application-Error");
            resposne.Headers.Add("Access-Control-Allow-Origin", "*");
        }

        public static int CalculcateAge(this DateTime theDateTime)
        {
            var age = DateTime.Today.Year - theDateTime.Year;
            if (theDateTime.AddYears(age) > DateTime.Today)
            {
                age--;
            }
            return age;
        }
    }
}
