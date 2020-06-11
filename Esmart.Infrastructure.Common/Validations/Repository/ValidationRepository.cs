using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Esmart.Infrastructure.Common.Validations.Contracts;
using System.Text.RegularExpressions;

namespace Esmart.Infrastructure.Common.Validations.Repository
{
    public class ValidationRepository : IValidationRepository
    {
        public bool ValidateEmail(string Email)
        {
            return Regex.IsMatch(Email.Trim(),
            @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
            @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-0-9a-z]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase);
        }

        public bool ValidateStringForSpaceAndSpecialCharacter(string String)
        {
            var regexItem = new Regex("^[a-zA-Z ]*$");
            return regexItem.Match(String).Success;
        }
    }
}
