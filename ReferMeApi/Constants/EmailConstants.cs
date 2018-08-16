using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ReferMeApi.Constants
{
    public static class EmailConstants
    {
        // General email constants

        public const string FROM_EMAIL_ADDRESS = "";
        public const string FROM_EMAIL_NAME = "Referrify";
        public const string FROM_EMAIL_PASSWORD = "";

        public const string SMTP_HOST = "smtp.gmail.com";
        public const int SMTP_PORT = 587;

        // Account verfication email constants

        public const string ACCOUNT_VERFICATION_EMAIL_SUBJECT = "Please Verify Your Email Address";
    }
}
