namespace cat.itb.M6UF2Pr.model
{
    public class Product
    {
        public int Id { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        public int CurrentStock { get; set; }
        public int MinStock { get; set; }
        public float Price { get; set; }
        public Employee Responsible { get; set; }
        public List<Supplier> Suppliers { get; set; }
    }
}
