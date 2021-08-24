namespace DCronHttp.Shared.Cron
{
    public class CronEntry
    {
        public string Expression { get; set; }
        public string Url { get; set; }
        
        public bool NotifyOnSuccess { get; set; } = false;
        public bool NotifyOnFailure { get; set; } = true;

        public bool NotifyByEmail { get; set; } = false;
        public string[] EmailAddresses { get; set; }

        public bool NotifyBySms { get; set; } = false;
        public string[] CellPhoneNumbers { get; set; }
    }
}