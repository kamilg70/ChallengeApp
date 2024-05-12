using ChallengeApp;
Employee employee1 = new Employee("Jola","Nowak ","19");
Employee employee2 = new Employee("Kamil", "Nowak","20");
Employee employee3 = new Employee("Marcin", "Nowak", "3");

employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(7);
employee1.AddScore(4);
employee1.AddScore(1);

employee2.AddScore(9);
employee2.AddScore(12);
employee2.AddScore(15);
employee2.AddScore(18);
employee2.AddScore(11);

employee3.AddScore(1);
employee3.AddScore(4);
employee3.AddScore(2);
employee3.AddScore(5);
employee3.AddScore(9);

List<Employee> employees = new List<Employee>()
{ employee1, employee2, employee3
};

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach(var employee in employees)
    {
    if(employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }

}
Console.WriteLine("Pracownik z najwyższą liczbą ocen to:" + employeeWithMaxResult.Name + "  "+employeeWithMaxResult.Surname + "  wiek="+employeeWithMaxResult.Age);
Console.WriteLine("jego wynik to "+employeeWithMaxResult.Result);
