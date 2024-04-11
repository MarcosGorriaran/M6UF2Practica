
using FluentNHibernate.Mapping;

namespace cat.itb.M6UF2Pr
{
    public class SupplierMap : ClassMap<Supplier>
    {
        public SupplierMap()
        {
            Table("SUPPLIER");

            Id(sup => sup.Id);
            Map(sup => sup.Name).Column("name");
            Map(sup => sup.Address).Column("address");
            Map(sup => sup.City).Column("city");
            Map(sup => sup.StreetCode).Column("stcode");
            Map(sup => sup.ZipCode).Column("zipcode");
            Map(sup => sup.Area).Column("area");
            Map(sup => sup.Phone).Column("phone");
            References(sup => sup.Product).Column("productno");
            Map(sup => sup.Amount).Column("amount");
            Map(sup => sup.Credit).Column("credit");
            Map(sup => sup.Remark).Column("remark");
            HasMany(sup => sup.Orders).KeyColumn("supplierno").Cascade.AllDeleteOrphan().AsSet();
        }
    }
}
