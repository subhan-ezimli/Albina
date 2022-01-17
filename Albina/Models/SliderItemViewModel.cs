using Repository.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Albina.Models
{
    public class SliderItemViewModel
    {
        public SliderPosition Position { get; set; }

        public int OrderBy { get; set; }
        
        public string Title { get; set; }
      
        public string Slogan { get; set; }
        
        public string Image { get; set; }
      
        public string EndPoint { get; set; }
      
        public string ActionTest { get; set; }
    }
}
