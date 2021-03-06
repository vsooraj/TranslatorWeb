﻿using Ivedix.Translator.Web.Models;
using System.Collections.Generic;

namespace Ivedix.Translator.Web.ViewModels
{
    public class TranslationViewModel
    {
        public string Title { get; set; }
        public List<Translation> Translations { get; set; }
    }
}
