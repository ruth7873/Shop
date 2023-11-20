namespace Shop_ruthHershler.Entities
{
    public enum EmployeePosition { Manager,Cashier, Salesman } 
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public EmployeePosition Positin { get; set; }


    }
}
