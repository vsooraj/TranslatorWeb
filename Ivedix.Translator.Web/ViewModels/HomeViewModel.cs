using Ivedix.Translator.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ivedix.Translator.Web.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public List<Platform> Platforms { get; set; }
    }
}
