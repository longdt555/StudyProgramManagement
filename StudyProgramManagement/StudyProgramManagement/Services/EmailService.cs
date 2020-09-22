using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace StudyProgramManagement.Services
{
    public class EmailService
    {
        public void SendEmail(string username, string newpass, string emailTo)
        {
            try
            {
                SmtpClient client = new SmtpClient("pro22.emailserver.vn");
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("spmsystem1408@gmail.com", "M@tkhau1");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("spmsystem1408@gmail.com");
                mailMessage.To.Add(emailTo);
                mailMessage.Body = $"You SPM Account: {username} has been reset password to {newpass} . Please try to log in. ";
                mailMessage.Subject = "Your SPM password has been changed";

                client.SendCompleted += (s, e) =>
                {
                    client.Dispose();
                    mailMessage.Dispose();
                };
                client.SendAsync(mailMessage, null);
                //client.SendAsync(mailMessage);
                //client.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void SendEmailInitDB(string username, string newpass, string emailTo)
        {
            try
            {
                SmtpClient client = new SmtpClient("pro22.emailserver.vn ");
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("spmsystem1408@gmail.com", "M@tkhau1");

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("spmsystem1408@gmail.com", "Smart Loyalty");
                mailMessage.To.Add(emailTo);
                mailMessage.Body = $"You Smart Loyalty Account: {username} and password {newpass}. Please try to log in. ";
                mailMessage.Subject = "Your Smart Loyalty acount has been created";

                client.SendCompleted += (s, e) =>
                {
                    client.Dispose();
                    mailMessage.Dispose();
                };
                client.SendAsync(mailMessage, null);
                //client.SendAsync(mailMessage);
                //client.Dispose();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public string GetRefererEmailContent(string url)
        {
            string content = @"";
            return content;
        }
    }
}