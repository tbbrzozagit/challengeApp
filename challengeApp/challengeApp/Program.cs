Employee employee1 = new Employee("Piotr", "Kłopotek", 35);
Employee employee2 = new Employee("Michał", "Wiaderko", 29);
Employee employee3 = new Employee("Marcin", "Szypa", 32);

employee1.AddScore(9);
employee1.AddScore(9);
employee1.AddScore(7);
employee1.AddScore(9);
employee1.AddScore(8);

employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(8);
employee2.AddScore(8);

employee3.AddScore(5);
employee3.AddScore(7);
employee3.AddScore(6);
employee3.AddScore(4);
employee3.AddScore(7);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};



int maxResult = -1;
Employee employeeWithMaxResult = null;


foreach (var employee in employees)
{

    if (employee.Result > maxResult)
    {
        employeeWithMaxResult = employee;
        maxResult = employee.Result;
    }

}
Console.WriteLine("Nalepszy wynik zdobył: " + employeeWithMaxResult.Name + " " + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age);
Console.WriteLine("z sumą punktów " + employeeWithMaxResult.Result);


class Employee
{
    private List<int> score = new List<int>();
    public Employee(string name, string surname, int age)
    {
        this.Name = name;
        this.Surname = surname;
        this.Age = age;
    }   
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public int Result
    {
        get
        {
            return this.score.Sum();
        }
    }
    public void AddScore(int number)
    {
        this.score.Add(number);
    }
}

