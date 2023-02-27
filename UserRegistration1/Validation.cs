using System.Reflection;
using System.Text.RegularExpressions;


namespace UserRegistration1
{
    public class Validation
    {
        public bool ValidName(string name)
        {
            bool flag = false;
            //string pattern = @"^[A-Z]{1}[a-z]{2,}\s[A-Z]{1}[a-z]{2,}";
            Regex rx = new Regex(@"^[A-Z]{1}[a-z]{2,}\s[A-Z]{1}[a-z]{2,}");
            Match match = rx.Match(name);
            if (match.Success)
            {
                flag = true;

            }
            return flag;
        }
        public bool ValidEmail(string email)
        {
            bool flag = false;
            Regex rx = new Regex(@"^[a-z0-9\w]{3,}@([-a-z0-9]+.)+[a-z]{2,5}$");
            Match match = rx.Match(email);
            if (match.Success)
            {
                flag = true;
                return flag;
            }

            return flag;
            
        }

        public bool ValidMobile(string mobile)
        {
            bool flag = false;
            Regex rx = new Regex(@"^[0-9]{2}\s[0-9]{10}");
            Match match = rx.Match(mobile);
            if(match.Success)
            {
                flag = true;
                return flag;

            }
            return flag;

           
        }
        public bool ValidPass(string pass)
        {
            bool flag= false;
            Regex regex = new Regex(@"^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*\W)(?!.* ).{8}");
            Match match = regex.Match(pass);
            if(match.Success)
            {
                flag = true;
                return flag;
            }
            return flag;
        }
    }
}