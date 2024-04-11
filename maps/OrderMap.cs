using FluentNHibernate.Mapping;

namespace cat.itb.M6UF2Pr
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap() 
        {
            Table("ORDERP");

            Id(ord=>ord.Id);
            References(ord=>ord.Supplier).Column("supplierno");
            Map(ord => ord.OrderDate).Column("orderdate");
            Map(ord => ord.Amount).Column("amount");
            Map(ord => ord.DeliveryDate).Column("deliverydate");
            Map(ord => ord.Cost).Column("cost");
        }
    }
}
