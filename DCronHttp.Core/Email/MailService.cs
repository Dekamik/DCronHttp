using System.Collections.Generic;
using System.Linq;
using System.Text;
using DCronHttp.Shared;
using MimeKit;
using MimeKit.Text;

namespace DCronHttp.Core.Email
{
    public class EmailService
    {
        private readonly SmtpClientFactory _smtpClientFactory;

        public EmailService(SmtpClientFactory smtpClientFactory)
        {
            _smtpClientFactory = smtpClientFactory;
        }

        public void Send(IEnumerable<string> to, string subject, string message)
        {
            var mimeMessage = new MimeMessage();
            mimeMessage.From.Add(new MailboxAddress(Encoding.UTF8, 
                EnvironmentVariables.DCRONHTTP_MAILFROM_NAME, 
                EnvironmentVariables.DCRONHTTP_MAILFROM_ADDRESS));
            mimeMessage.To.AddRange(to.Select(MailboxAddress.Parse));
            mimeMessage.Subject = subject;
            mimeMessage.Body = new TextPart(TextFormat.Plain)
            {
                Text = message
            };
            
            Send(mimeMessage);
        }

        public void Send(MimeMessage message)
        {
            using var client = _smtpClientFactory.Create();
            client.Connect(EnvironmentVariables.DCRONHTTP_MAILSERVER_ADDRESS, 
                EnvironmentVariables.DCRONHTTP_MAILSERVER_PORT, 
                EnvironmentVariables.DCRONHTTP_MAILSERVER_USESSL);
            client.Authenticate(EnvironmentVariables.DCRONHTTP_MAILSERVER_USERNAME, 
                EnvironmentVariables.DCRONHTTP_MAILSERVER_PASSWORD);
            
            client.Send(message);
        }
    }
}