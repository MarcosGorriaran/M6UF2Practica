namespace cat.itb.M6UF2Pr.model
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StreetCode { get; set; }
        public string ZipCode { get; set; }
        public int Area { get; set; }
        public string Phone {  get; set; }
        public Product Product { get; set; }
        public int Amount { get; set; }
        public float Credit { get; set; }
        public string Remark { get; set; }
        public List<Order> Orders { get; set; }
    }
}
