namespace EntityFramework.Model
{
    public class Product : Entity
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool IsActive { get; set; } 

        public Product AddMacBook()
        {
            return new Product()
            {
                Description = "MacBook Air 2015",
                Price = 4590.99M,
                IsActive = true                
            };
        }

        public Product AddNvidiaRTX()
        {
            return new Product()
            {
                Description = "NVidia RTX 3090 Ti",
                Price = 18590.99M,
                IsActive = true
            };
        }
    }
}