using FluentNHibernate.Mapping;

namespace cat.itb.M6UF2Pr
{
    public class ProductMap : ClassMap<Product>
    {
        public ProductMap() 
        {
            Table("PRODUCT");

            Id(pro => pro.Id);
            Map(pro => pro.Code).Column("code");
            Map(pro => pro.Description).Column("description");
            Map(pro => pro.CurrentStock).Column("currentstock");
            Map(pro => pro.MinStock).Column("minstock");
            Map(pro => pro.Price).Column("price");
            References(pro => pro.Responsible).Column("empno");
            HasOne(pro => pro.Supplier).PropertyRef(nameof(Supplier.Product)).Fetch.Join();
        }
    }
}
