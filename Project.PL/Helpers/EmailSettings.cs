using Project.DAL.Models;

using System.Net;
using Microsoft.Extensions.Options;
using Project.PL.Settings;
using MimeKit;
using MailKit.Net.Smtp;

namespace Project.PL.Helpers
{
    public class EmailSettings : IEmailSettings
    {
        private readonly MailSettings option;
        public EmailSettings(IOptions<MailSettings> _option)
        {
            option = _option.Value;
        }
        public void SendEmail(Email email)
        {
            var mail = new MimeMessage()
            {
                Sender = MailboxAddress.Parse(option.Email),
                Subject = email.Subject
            };
            mail.To.Add(MailboxAddress.Parse(email.To));
            mail.From.Add(new MailboxAddress(option.DisplayName, option.Email));

            var builder = new BodyBuilder();
            builder.TextBody=email.Body;
            mail.Body=builder.ToMessageBody();

            using var smtp = new SmtpClient();
            smtp.Connect(option.Host, option.Port, MailKit.Security.SecureSocketOptions.StartTls);
            smtp.Authenticate(option.Email,option.Password);
            smtp.Send(mail);

            smtp.Disconnect(true);
        }
    }
}
