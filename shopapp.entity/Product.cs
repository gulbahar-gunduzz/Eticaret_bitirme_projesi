using System.Collections.Generic;

namespace shopapp.entity
{
    // �r�nler s�n�f� olu�turuldu
    public class Product
    {
        public int ProductId { get; set; }  
        public string Name { get; set; }       
        public double? Price { get; set; } 
        public string Description { get; set; }         
        public string ImageUrl { get; set; }
        public bool IsApproved { get; set; }

        public List<ProductCategory> ProductCategories { get; set; }
    }
}