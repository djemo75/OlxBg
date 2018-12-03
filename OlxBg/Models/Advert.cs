using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlxBg.Data
{
    public class Advert
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Cat { get; set; }
        public double Price { get; set; }
        public string Author { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }
        public string ImageName { set; get; }
    }
}
