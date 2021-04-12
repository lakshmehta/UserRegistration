using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegisatration
{
    public class Pattern
    {
        public bool isValidFirstName(string firstName)
        {
            string firstNameRegex = "^[A-Z][a-zA-Z]{2,}";
            Regex regex = new Regex(firstNameRegex);
            try
            {
                if (regex.IsMatch(firstName))
                {
                    return true;
                }
                else
                {
                    throw new UserException(UserException.ExceptionType.INVALID_FIRST_NAME, "Invalid_First_Name");
                }

            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
        public bool isValidLastName(string lastName)
        {
            string lastNameRegex = "^[A-Z][a-zA-Z]{2,}";
            Regex regex = new Regex(lastNameRegex);
            try
            {
                if (regex.IsMatch(lastName))
                {
                    return true;
                }
                else
                {
                    throw new UserException(UserException.ExceptionType.INVALID_LAST_NAME, "Invalid_Last_Name");
                }

            }
            catch (UserException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }

        }
    }
}
