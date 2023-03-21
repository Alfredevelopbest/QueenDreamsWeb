using System.Numerics;

namespace WebQueenDreams.Entity
{
    public class Product
    {
        public  int Id { get; set; }
        public string ReferenceCode { get; set; }
        public double SaleProductPrice { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public int StandardSizeId { get; set; }
        public BigInteger ProductImageId { get; set; } 

    }
}
