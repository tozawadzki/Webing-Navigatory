using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B2TomaszZawadzkiZadDom6.ViewModels
{
    public class TemplatesVM
    {
        public TemplatesVM(string website, string content, string level, string logo)
        {
            Website = website;
            Content = content;
            Level = level;
            Logo = logo;
        }
        public string Website { get; set; }
        public string Content { get; set; }
        public string Level { get; set; }
        public string Logo { get; set; }
    }
}