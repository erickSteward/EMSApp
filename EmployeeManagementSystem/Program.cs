using System;
using System.Data;

class Employee
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public string? Department { get; set; }

}

class EmployeeManageSystem
{
    List<Employee> employeeList;
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
                    // Console.WriteLine("Employee Added\n");
                    EmployeeManageSystem.AddEmployee();
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

    public void AddEmployee()
    {
        Console.WriteLine("You are entering an Employee");
        Console.WriteLine("Please enter Employee ID : ");
       
        while(true){
            if(int.TryParse(Console.ReadLine(), out int employeeID) && IsUniqueID(employeeID)){
                Console.WriteLine("Please enter Employee Name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Employee Department that the Employee belong: ");
                string department = Console.ReadLine();
                employeeList.Add(new Employee{
                    Id = employeeID,
                    Name = name,
                    Department = department
                });
                Console.WriteLine("Employee Added Successfully.");
            }
            else{
                Console.WriteLine("Employee ID has to be a unquie and a valid Interger");
            }
        }

    }

    bool IsUniqueID(int employeeID){
        return !employeeList.Any(e => e.Id == employeeID);
    }
}