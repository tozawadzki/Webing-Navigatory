using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B2TomaszZawadzkiZadDom6.ViewModels
{
    public class StudyAidVM
    {
        public StudyAidVM(string website, string function, string logo)
        {
            Website = website;
            Function = function;
            Logo = logo;
        }
        public string Website { get; set; }
        public string Function { get; set; }
        public string Logo { get; set; }
    }
}