using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArsaProject.EntityLayer.Concrete
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductImage { get; set; }
        public int ProductPrice { get; set; }
        public string ProductTitle { get; set; }
        public string ProductDescription { get; set; }
        public string ProductDescription2 { get; set; }
        public double Latitude { get; set;}
        public double Longitude { get; set; }
        public double Zoom { get; set; }
        public string LatLng { get; set; }


    }
}
