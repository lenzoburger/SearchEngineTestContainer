﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
namespace WebDriverWrapper
{
    public class SeleniumWrapper
    {
        public void parseJson(string json)
        {
            var ourJsonObject = JObject.Parse(json);
            if ((bool)ourJsonObject["LikeThisCourse"])
            {
                var firstName = (string)ourJsonObject["FirstName"];
                var lastName = (string)ourJsonObject["LastName"];
                var age = (int)ourJsonObject["Age"];
            }
        }


    }
}
