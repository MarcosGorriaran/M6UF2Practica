namespace cat.itb.M6UF2Pr.model
{
    public class Order
    {
        public int Id { get; set; }
        public Supplier Supplier { get; set; }
        public DateTime OrderDate { get; set; }
        public int Amount { get; set; }
        public DateTime DeliveryDate { get; set; }
        public float Cost { get; set; }
    }
}
