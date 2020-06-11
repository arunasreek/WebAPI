using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Esmart.Infrastructure.EmailUtility.Contract;
using Esmart.Infrastructure.Resources;

namespace Esmart.Infrastructure.EmailUtility.Classes
{
    public class EmailSenderUtilityService : IEmailSenderUtilityService
    {
        public async Task<Response> SendInitialEmail(string sendTo, string userFirstName, string newUserActivationLink, bool isStaticEmailStatus)
        {
            var apiKey = AppKeys.SENDGRID_API_KEY;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prem@test.com", "Arun Prem");
            // commented the below link to aviod sending email to unknow emailid when testing
            // var to = new EmailAddress(sendTo, userFirstName);

            var to = new EmailAddress(isStaticEmailStatus ? "lingraj.gowda@teganalytics.com" : sendTo, userFirstName); // for testing email is hardcoded
            var subject = userFirstName + ", Welcome to IntellMix!";
            var htmlContent = "Hi " + userFirstName + ", <br><br>" +
                              "Welcome! You have joined your team and ours.<br>" +
                              "Click on the below link to set up password to get started.<br>" +
                               "<a href=" + newUserActivationLink + ">"+ newUserActivationLink +"</a>" +
                              "<br><br>Regards<br>" +
                              "The IntellMix Team";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlContent);
            return await client.SendEmailAsync(msg);
        }

        public async Task<Response> SendForgetEmailAsync(string sendTo, string userFirstName, string mailSubject, string userActivationLink, bool isStaticEmailStatus)
        {
            var apiKey = AppKeys.SENDGRID_API_KEY;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prem@test.com", "Arun Prem");
            // commented the below link to aviod sending email to unknow emailid when testing
            // var to = new EmailAddress(sendTo, userFirstName);

            var to = new EmailAddress(isStaticEmailStatus ? "harsha.dass@teganalytics.com" : sendTo, userFirstName); // for testing email is hardcoded
            var subject = mailSubject;
            var htmlContent = "Hi " + userFirstName + ", <br><br>" +
                              "Click on the below link to reset up password.<br>" +
                               "<a href=" + userActivationLink + ">" + userActivationLink + "</a>" +
                              "<br><br>Regards<br>" +
                              "The IntellMix Team";
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlContent);
            return await client.SendEmailAsync(msg);
        }

        public async Task<Response> SendEmail(string sendTo, string userFirstName, string emailSubject, string emailTemplate, List<string> attachmentPath)
        {
            var apiKey = AppKeys.SENDGRID_API_KEY;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prem@test.com", "Arun Prem");
            // commented the below link to aviod sending email to unknow emailid when testing
            // var to = new EmailAddress(sendTo, userFirstName);

            var to = new EmailAddress("lingraj.gowda@teganalytics.com", userFirstName); // for testing email is hardcoded
            var subject = emailSubject.Trim();
            var htmlContent = emailTemplate.Replace("strUserName", userFirstName);
            var msg = MailHelper.CreateSingleEmail(from, to, subject, "", htmlContent);

            if (attachmentPath.Count != 0)
            {
                foreach (var item in attachmentPath)
                {
                    var bytes = File.ReadAllBytes(item);
                    var file = Convert.ToBase64String(bytes);
                    msg.AddAttachment(Path.GetFileName(item), file);
                }
            }
            return await client.SendEmailAsync(msg);
        }

        public async Task<Response> SendMultipleEmail(List<EmailAddress> tosEmailAddresses, string emailSubject, string emailTemplate)
        {
            var apiKey = AppKeys.SENDGRID_API_KEY;
            var client = new SendGridClient(apiKey);
            var from = new EmailAddress("prem@test.com", "Arun Prem");
            // commented the below link to aviod sending email to unknow emailid when testing
            // var to = new EmailAddress(sendTo, userFirstName);

          //  var to = new EmailAddress("harsha.dass@teganalytics.com", userFirstName); // for testing email is hardcoded
                                                                                      // var subject = emailSubject.Trim();
                                                                                      //var sub = new List<string>();
          //  var htmlContent = emailTemplate.Replace("strUserName", userFirstName);
            var msg = MailHelper.CreateSingleEmailToMultipleRecipients(from, tosEmailAddresses, emailSubject, emailTemplate, null);

            return await client.SendEmailAsync(msg);
        }
    }
}
