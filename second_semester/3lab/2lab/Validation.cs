using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _3lab
{
    public class UserNameAttribute : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value != null)
            {//проверить!
                Regex reg = new Regex("\\b<[qQ]w+");//начинается с q
                string userName = value.ToString();
                if (!reg.IsMatch(userName))
                    return true;
                else
                    ErrorMessage = "Name can not start with Q";
            }
            return false;
        }
    }
}
