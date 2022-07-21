using Microsoft.Extensions.Options;
using SerpantWebApp.Settings;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace SerpantWebApp.Services
{
    public class EmailService : IEmailService
    {
        private readonly IOptions<SMTPSetting> smtpSetting;

        public EmailService(IOptions<SMTPSetting> smtpSetting)
        {
            this.smtpSetting = smtpSetting;
        }
        public async Task SendAsync(string from, string to, string subject, string body)
        {
            var message = new MailMessage(
                from,
                to,
                subject,
                body
                   );
            using (var emailClient = new SmtpClient())
            {
                emailClient.Port = smtpSetting.Value.Port;
                emailClient.Host = smtpSetting.Value.Host;
                emailClient.EnableSsl = true;
                emailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                emailClient.Credentials = new NetworkCredential(smtpSetting.Value.User, smtpSetting.Value.Password);

                await emailClient.SendMailAsync(message);
            }

        }
    }
}
