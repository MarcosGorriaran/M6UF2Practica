namespace cat.itb.M6UF2Pr.model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Job {  get; set; }
        public Employee Manager { get; set; }
        public DateTime StartDate { get; set; }
        public float Salary { get; set; }
        public float Comision { get; set; }
        public int Deptno { get; set; }
        public List<Product> Products { get; set; }
    }
}
