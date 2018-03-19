using System.Collections.Generic;

namespace HIM.Core
{
    public class MailHeader
    {
        public string From { get; set; }
        public string SenderName { get; set; }
        public List<string> To { get; set; } = new List<string>();
        public List<string> CC { get; set; } = new List<string>();
        public List<string> BCC { get; set; } = new List<string>();
        public string Subject { get; set; }
        public string ReplyTo { get; set; }
        public string FromName { get; set; }
        public bool IsMailBodyManualSupply { get; set; }
        public bool IsEnquiry { get; set; }
    }
}
