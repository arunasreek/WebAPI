using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.Common.Validations.Contracts
{
    public interface IValidationRepository
    {
        bool ValidateEmail(string Email);
        bool ValidateStringForSpaceAndSpecialCharacter(string String);
    }
}
