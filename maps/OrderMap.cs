using cat.itb.M6UF2Pr.model;
using FluentNHibernate.Mapping;

namespace cat.itb.M6UF2Pr.maps
{
    public class OrderMap : ClassMap<Order>
    {
        public OrderMap() 
        {
            Id(ord=>ord.Id);
            References(ord=>ord.Supplier).Column("supplierno");
            Map(ord => ord.OrderDate).Column("orderdate");
            Map(ord => ord.Amount).Column("amount");
            Map(ord => ord.DeliveryDate).Column("deliverydate");
            Map(ord => ord.Cost).Column("cost");
        }
    }
}
