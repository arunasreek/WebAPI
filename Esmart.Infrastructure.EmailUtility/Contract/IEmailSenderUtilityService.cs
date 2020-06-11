using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esmart.Infrastructure.EmailUtility.Contract
{
    public interface IEmailSenderUtilityService
    {
        Task<Response> SendInitialEmail(string sendTo, string userFirstName, string newUserActivationLink, bool isStaticEmailStatus);
        Task<Response> SendForgetEmailAsync(string sendTo, string userFirstName, string mailSubject, string userActivationLink, bool isStaticEmailStatus);
        Task<Response> SendEmail(string sendTo, string userFirstName, string emailSubject, string emailTemplate, List<string> attachmentPath);
        Task<Response> SendMultipleEmail(List<EmailAddress> tosEmailAddresses, string emailSubject, string emailTemplate);
    }
}
