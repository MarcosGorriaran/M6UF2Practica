﻿using FluentNHibernate.Mapping;

namespace cat.itb.M6UF2Pr
{
    public class EmployeeMap : ClassMap<Employee>
    {
        public EmployeeMap()
        {
            Table("EMPLOYEE");

            Id(emp => emp.Id);
            Map(emp => emp.Surname).Column("surname");
            Map(emp => emp.Job).Column("job");
            References(emp => emp.Manager).Column("managerno");
            Map(emp => emp.StartDate).Column("startdate");
            Map(emp => emp.Salary).Column("salary");
            Map(emp => emp.Comision).Column("commission");
            Map(emp => emp.Deptno).Column("deptno");

            HasMany(emp => emp.Products).KeyColumn("empno").Cascade.AllDeleteOrphan().AsSet();
            HasMany(emp => emp.Lackeys).KeyColumn("managerno").AsSet();
        }
    }
}
