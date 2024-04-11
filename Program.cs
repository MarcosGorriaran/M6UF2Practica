namespace cat.itb.M6UF2Pr;

public class Driver
{
    /**
     * El script sql ha sido alterado para reflejar la relacion de los empleados que tienen jefes
     */
    public static void Main()
    {
        const string Menu = "1. InsertADO\n"+
            "13. Exit";
        const string InsertADOShow = "{0} empleados insertados correctamente";
        const int InsertADOOption = 1;
        const int UpdateProductADOOption = 2;
        const int ExitOption = 13;
        EmployeeCRUD empCRUD = new EmployeeCRUD();
        ProductCRUD productCRUD = new ProductCRUD();
        int option;
        int inserts;
        do
        {
            Console.WriteLine(Menu);
            option = Convert.ToInt32(Console.ReadLine());
            
            switch (option)
            {
                case InsertADOOption:
                    inserts = empCRUD.InsertADO(new List<Employee>(new Employee[]{
                        new Employee()
                        {
                            Surname="SMITH",
                            Job="DIRECTOR",
                            Manager=empCRUD.SelectById<int>(9),
                            StartDate=DateTime.Parse("1988-12-12"),
                            Salary=118000,
                            Comision=52000,
                            Deptno=10
                        },
                        new Employee()
                        {
                            Surname="JOHNSON",
                            Job="VENEDOR",
                            Manager=empCRUD.SelectById<int>(4),
                            StartDate=DateTime.Parse("1992-02-25"),
                            Salary=125000,
                            Comision=30000,
                            Deptno=30
                        },
                        new Employee()
                        {
                            Surname="HAMILTON",
                            Job="VENEDOR",
                            Manager=empCRUD.SelectById<int>(7),
                            StartDate=DateTime.Parse("1989-03-18"),
                            Salary=172000,
                            Comision=null,
                            Deptno=10
                        },
                        new Employee()
                        {
                            Surname="SMITH",
                            Job="DIRECTOR",
                            Manager=empCRUD.SelectById<int>(9),
                            StartDate=DateTime.Parse("1988-12-12"),
                            Salary=192000,
                            Comision=null,
                            Deptno=10
                        }
                    }));
                    Console.WriteLine(InsertADOShow,inserts);
                    break;
                case UpdateProductADOOption:

                    break;
            }
        } while (option != ExitOption);
    }
}