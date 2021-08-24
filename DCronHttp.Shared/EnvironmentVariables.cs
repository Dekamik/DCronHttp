using System;

namespace DCronHttp.Shared
{
    // ReSharper disable InconsistentNaming
    public static class EnvironmentVariables
    {
        #region Email

        public static string DCRONHTTP_MAILSERVER_ADDRESS =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_MAILSERVER_ADDRESS));
        
        public static int DCRONHTTP_MAILSERVER_PORT => int.Parse(Environment.GetEnvironmentVariable(nameof(DCRONHTTP_MAILSERVER_PORT)) ?? "0");
        
        public static bool DCRONHTTP_MAILSERVER_USESSL => bool.Parse(Environment.GetEnvironmentVariable(nameof(DCRONHTTP_MAILSERVER_USESSL)) ?? "false");
        
        public static string DCRONHTTP_MAILSERVER_USERNAME =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_MAILSERVER_USERNAME));

        public static string DCRONHTTP_MAILSERVER_PASSWORD =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_MAILSERVER_PASSWORD));

        public static string DCRONHTTP_MAILFROM_NAME =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_MAILFROM_NAME));

        public static string DCRONHTTP_MAILFROM_ADDRESS =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_MAILFROM_ADDRESS));

        #endregion

        #region Twilio

        public static string DCRONHTTP_TWILIO_ACCOUNTSID =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_TWILIO_ACCOUNTSID));

        public static string DCRONHTTP_TWILIO_AUTHTOKEN =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_TWILIO_AUTHTOKEN));

        public static string DCRONHTTP_SMSFROM_NUMBER =>
            Environment.GetEnvironmentVariable(nameof(DCRONHTTP_SMSFROM_NUMBER));

        #endregion
    }
}