using System;

namespace Ivedix.Translator.Web.Models
{
    public class TranslationHistory
    {

        public int Id { get; set; }
        public int KeyId { get; set; }
        public int LanaguageId { get; set; }
        public string TranslationValue { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }

}
