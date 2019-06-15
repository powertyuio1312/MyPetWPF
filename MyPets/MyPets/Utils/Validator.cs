using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MyPets
{
    public class Validator
    {
        public static string ValidLogin(string login)
        {

            string[] dataLogin = login.Split('@'); 
            if (dataLogin.Length == 2) 
            {
                string[] data2Login = dataLogin[1].Split('.'); 
                if (data2Login.Length == 2)
                {
                    return "";
                }
                {
                    
                    return "Укажите логин в форме х@x.x";
                }
            }
            else
            {               
                return "Укажите логин в форме х@x.x";
            }
        }

        public static bool ValidPass(string pass)
        {
            var hasSpace = new Regex(@"\s+");
            var hasNumber = new Regex(@"[0-9]+"); 
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-s]+");
            var hasMinimum8Chars = new Regex(@".{6,}");

            var s = hasNumber.IsMatch(pass) && hasUpperChar.IsMatch(pass) && hasLowerChar.IsMatch(pass) 
                && hasMinimum8Chars.IsMatch(pass) && !hasSpace.IsMatch(pass);
            return s;
        }

        public static bool ValidName(string name)
        {
            var hasUpperChar = new Regex(@"[A-Z]+");
            var hasLowerChar = new Regex(@"[a-s]+");

            var s = hasUpperChar.IsMatch(name) && hasLowerChar.IsMatch(name);
            return s;
        }

        public static bool ValidAgeWeight(string age, string weight)
        {
            int valAge = int.Parse(age);
            int valWeight = int.Parse(weight);
            if (valAge > 0 || valWeight > 0)
            {
                return true;
            }
            else return false;
        }

        public static bool ValidAgeWeight(string weight)
        {
            var comma = new Regex(@"[0-9]+\,+[0-9,]+");
            if (comma.IsMatch(weight))
            {
                double valWeight = Convert.ToDouble(weight);
                if (valWeight > 0)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        
    }
}
