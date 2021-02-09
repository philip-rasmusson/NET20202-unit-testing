using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UnitTestingTwo
{
    public class Userdata
    {
        public bool IsPasswordOK(string password)
        {
            var list = new[] {"~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "="};
        
            if (password.Length >= 6 && password.Length <= 25)
            {
                if (password.Any(char.IsUpper) && password.Any(char.IsLower) && list.Any(password.Contains))
                {
                    return true;
                }
            }



            return false;
        }
        public bool IsEmailOK(string email)
        { return false; }
        public bool IsPhoneOK(string phone)
        { return false; }
    }




}
