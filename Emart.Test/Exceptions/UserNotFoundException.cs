using System;
using System.Collections.Generic;
using System.Text;

namespace Emart.Test.Exceptions
{
    public class UserNotFoundException : Exception
    {

        public string Messages = "User is Not found in Userlist";

        public UserNotFoundException(string message)
        {
            this.Messages = message;
        }
    }

}
