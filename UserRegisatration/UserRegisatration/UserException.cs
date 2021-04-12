using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegisatration
{
    public class UserException : Exception
    {
        public enum ExceptionType
        {
            INVALID_FIRST_NAME,
            INVALID_LAST_NAME,
            INVALID_MOBILE_NUMBER,
            INVALID_EMAIL_ID,
            INVALID_PASSWORD,

        }
        private readonly ExceptionType type;
        public UserException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
