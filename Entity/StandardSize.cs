namespace WebQueenDreams.Entity
{
    public class StandardSize
    {
        public int Id { get; set; }
        public double DimensionLenght { get; set; }
        public string SizeName { get; set; }
        public List<Product> products { get; set; }
    }
}
