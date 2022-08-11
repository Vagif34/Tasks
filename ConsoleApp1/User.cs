using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class User
    {
        private string username;
        private string posword;

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                if (value.Length > 6)
                {
                    username = value;
                }
            }
            
        }
        public string Posword
        {
            get
            {
                return posword;
            }
            set
            {
                if (value.Length > 8)
                {
                    value = posword;
                }
            }
        }
    }
}
