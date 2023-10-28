using System;
using System.Data;

class employee
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? Department { get; set; }

}

class EmployeeManageSystem
{
    List<employee> employeeList = new List<employee>();
    static void Main()
    {
        displayMenu();
    }

    static void displayMenu()
    {
        Console.WriteLine("*******************************************");
        Console.WriteLine("Welcome to Employee Management System");
        Console.WriteLine("*******************************************");
        Console.WriteLine($"1. Add an employee\n" +
            "2. View Employee(s)\n" +
            "3. Delete Employee\n" +
            "4. Find an Employee(s)\n" +
            "5. Exit");
        Console.WriteLine("Please choose operation number you want to do: ");
        String choose = Console.ReadLine();

        if (int.TryParse(choose, out int chooseNumber))
        {
            switch (chooseNumber)
            {
                case 1:
                    Console.WriteLine("Employee Added\n");
                    displayMenu();
                    break;
                case 2:
                    Console.WriteLine("Viewing Employees\n");
                    displayMenu();
                    break;
                case 3:
                    Console.WriteLine("Deleting an Employee\n");
                    displayMenu();
                    break;
                case 4:
                    Console.WriteLine("Finding an Employee\n");
                    displayMenu();
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid Input\n");
                    displayMenu();
                    break;
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid integer.");
            displayMenu();
        }

        
    }

    void addEmployee()
    {

    }
}