namespace cat.itb.M6UF2Pr
{
    public class Supplier
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Address { get; set; }
        public virtual string City { get; set; }
        public virtual string StreetCode { get; set; }
        public virtual string ZipCode { get; set; }
        public virtual int Area { get; set; }
        public virtual string Phone {  get; set; }
        public virtual Product Product { get; set; }
        public virtual int Amount { get; set; }
        public virtual float Credit { get; set; }
        public virtual string Remark { get; set; }
        public virtual IList<Order> Orders { get; set; }
    }
}
