using System.Numerics;

namespace WebQueenDreams.Entity
{
    public class ProductImage
    {
        public BigInteger Id { get; set; }
        public string IdIdentifier { get; set; }
        public string ImageName { get; set; }
        public List<Product> products { get; set; }
    }
}
