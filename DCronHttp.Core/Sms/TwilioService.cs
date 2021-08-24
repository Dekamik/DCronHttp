using DCronHttp.Shared;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace DCronHttp.Core.Sms
{
    public class TwilioService
    {
        public TwilioService()
        {
            TwilioClient.Init(
                EnvironmentVariables.DCRONHTTP_TWILIO_ACCOUNTSID, 
                EnvironmentVariables.DCRONHTTP_TWILIO_AUTHTOKEN);
        }

        public void Send(string to, string body)
        {
            MessageResource.Create(
                body: body, 
                from: EnvironmentVariables.DCRONHTTP_SMSFROM_NUMBER,
                to: to);
        }
    }
}