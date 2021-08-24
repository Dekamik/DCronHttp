using MailKit.Net.Smtp;

namespace DCronHttp.Core.Email
{
    public class SmtpClientFactory
    {
        public ISmtpClient Create() => new SmtpClient();
    }
}