using ReferMeApi.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace ReferMeApi.Helpers
{
    public static class EmailHelper
    {
        /// <summary>
        /// Sends Account Verification Email
        /// </summary>
        /// <param name="emailAddress">Recepient's email address</param>
        /// <param name="verficationCode">Account verification code</param>
        public static void SendAccountVerficationEmail(string emailAddress, string verficationCode)
        {
            string verificationLink = ApplicationConstants.APPLICATION_ACCOUNT_VERIFICATION_BASE_ADDRESS + verficationCode;
            string emailBody = EmailTemplates.ACCOUNT_VERFICATION_EMAIL.Replace("{{VERIFICATION_LINK}}", verificationLink);

            SendEmail(emailAddress, EmailConstants.ACCOUNT_VERFICATION_EMAIL_SUBJECT, emailBody);
        }

        /// <summary>
        /// Sends an email when provided with a recepient email address, subject and body
        /// </summary>
        /// <param name="emailAddress">Recepient's email address</param>
        /// <param name="subject">Email subject</param>
        /// <param name="body">Email body</param>
        public static void SendEmail(string emailAddress, string subject, string body)
        {
            var fromAddress = new MailAddress(EmailConstants.FROM_EMAIL_ADDRESS, EmailConstants.FROM_EMAIL_NAME);
            var toAddress = new MailAddress(emailAddress);

            var smtp = new SmtpClient
            {
                Host = EmailConstants.SMTP_HOST,
                Port = EmailConstants.SMTP_PORT,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, EmailConstants.FROM_EMAIL_PASSWORD)
            };

            using (var message = new MailMessage(fromAddress, toAddress) {
                Subject = subject,
                Body = body,
                IsBodyHtml = true
            })
            {
                smtp.Send(message);
            }
        } 
    }
}
