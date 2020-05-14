﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace Membership_app.Extensions
{
    public static class EmailExtensions
    {
        public static void Send(this IdentityMessage message)
        {
            try
            {
                // Read setting from Web.Config
                var password = ConfigurationManager.AppSettings["password"];
                var from = ConfigurationManager.AppSettings["from"];
                var host = ConfigurationManager.AppSettings["host"];
                var port = int.Parse(ConfigurationManager.AppSettings["port"]);

                // Create the email to send
                var email = new MailMessage(from, message.Destination, message.Subject, message.Body)
                {
                    IsBodyHtml = true
                };

                // Create an SMTP client to send the email
                var client = new SmtpClient(host, port);
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential(from, password);

                // Send the email
                client.Send(email);
            }
            catch { }


        }
    }
}