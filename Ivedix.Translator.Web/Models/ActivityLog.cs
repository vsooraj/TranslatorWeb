using System;

namespace Ivedix.Translator.Web.Models
{
    public class ActivityLog
    {

        public int Id { get; set; }
        public int ActivityTypeId { get; set; }
        public int ReferenceId { get; set; }
        public string Message { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}
