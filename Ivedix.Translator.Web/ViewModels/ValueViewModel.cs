using Ivedix.Translator.Web.Models;
using System.Collections.Generic;

namespace Ivedix.Translator.Web.ViewModels
{
    public class ValueViewModel
    {
        public string Title { get; set; }
        public List<Platformkey> Platformkeys { get; set; }
    }
}
