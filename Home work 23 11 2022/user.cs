using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Class_Home_Work
{
    internal class USER
    {
        protected string _userName;
        public string UserName
        {
            get

            {
                return _userName;
            }
            set

            {
                if (value.Length > 6)
                {
                    _userName = value;
                }
                else
                {
                    _userName = "UserName-i zehmet deyilse yeniden daxil edin";
                }

            }
        }

        protected string _password;
        public string Password

        {
            get
            {

                return _password;

            }
            set
            {
                if (value.Length > 1)
                {
                    if (value == value.ToLower())
                    {
                        _password = "write correct password";
                    }
                    else
                    {
                        _password = value;
                    }
                }
                else
                {
                    _password = "write correct password";
                }

            }
        }


        public USER(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }

    }
}
