using cat.itb.M6UF2Pr.model;
using FluentNHibernate.Mapping;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace cat.itb.M6UF2Pr.maps
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap() 
        {
            Id(pro => pro.Id);
            Map(pro => pro.Code).Column("code");
            Map(pro => pro.Description).Column("description");
            Map(pro => pro.CurrentStock).Column("currentstock");
            Map(pro => pro.MinStock).Column("minstock");
            Map(pro => pro.Price).Column("price");
            References(pro => pro.Responsible).Column("empno");
            HasOne(pro => pro.Supplier).PropertyRef(nameof(Supplier.Product)).Cascade.AllDeleteOrphan();
        }
    }
}
