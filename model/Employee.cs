namespace cat.itb.M6UF2Pr
{
    public class Employee
    {
        public virtual int Id { get; set; }
        public virtual string Surname { get; set; }
        public virtual string Job {  get; set; }
        public virtual Employee Manager { get; set; }
        public virtual DateTime StartDate { get; set; }
        public virtual float Salary { get; set; }
        public virtual float? Comision { get; set; }
        public virtual int Deptno { get; set; }
        public virtual ISet<Product> Products { get; set; }
        public virtual ISet<Employee> Lackeys { get; set; }

        /*public virtual Employee(int id, string surname, string job, Employee manager, DateTime startTime,
                        float salary, float? comision, int deptno, List<Product> products) 
        {
            Id = id;
            Surname = surname;
            Job = job;
            Manager = manager;
            StartDate = startTime;
            Salary = salary;
            Comision = comision;
            Deptno = deptno;
            Products = products;
        }*/
    }
}
