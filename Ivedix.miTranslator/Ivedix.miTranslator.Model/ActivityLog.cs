using System;

namespace Ivedix.miTranslator.Model
{
    public class ActivityLog
    {
        public int ActivityLogID { get; set; }
        public string Message { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
