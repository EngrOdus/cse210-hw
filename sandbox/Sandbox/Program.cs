using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Sandbox Project.");

        HourlyEmployee hEmployee = new HourlyEmployee();
        hEmployee.SetPayRate(30);
        hEmployee.SetHoursWorked(40);
        hEmployee.SetName("Oducity");
        hEmployee.SetIdNumber("15ae6g");

        SalaryEmployee sEmployee = new SalaryEmployee();
        sEmployee.SetIdNumber("bdc334");
        sEmployee.SetName("Samson");
        sEmployee.SetSalary(70000);


        DisplayEmployeeInformation(hEmployee);
        DisplayEmployeeInformation(sEmployee); 
    }

    public static void DisplayEmployeeInformation(Employee employees)
    {
        Console.WriteLine($"Name: {employees.GetName()}{Environment.NewLine}ID Number: {employees.GetIdNumber()}{Environment.NewLine}Monthly Salary: {employees.GetPay()}");//
    }
}