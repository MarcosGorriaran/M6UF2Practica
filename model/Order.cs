namespace cat.itb.M6UF2Pr
{
    public class Order
    {
        public virtual int Id { get; set; }
        public virtual Supplier Supplier { get; set; }
        public virtual DateTime OrderDate { get; set; }
        public virtual int Amount { get; set; }
        public virtual DateTime DeliveryDate { get; set; }
        public virtual float Cost { get; set; }
    }
}
