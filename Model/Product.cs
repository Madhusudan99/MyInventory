using System.ComponentModel.DataAnnotations;

namespace MyInventory.Model
{
    public class Product
    {
        public  int id { get; set; }
        public string name { get; set; }
        public int quantity { get; set; }
        public string category { get; set; }
        public double price { get; set; }
        public string manufacturingCompany { get; set; }
        public string manufacturingCompanyContact { get; set; }
        public string distributerName { get; set; }
        public string distributerContact { get; set; }
        public  string address { get; set; }
        public  string city { get; set; }
        public  string state { get; set; }
        public  string country { get; set; }
        public  string zipcode { get; set; }

        [DataType(DataType.Date)]
        public DateTime importDate { get; set; } = DateTime.Now;

        [DataType(DataType.Date)]
        public DateTime sellingDate { get; set; }



    }
}
