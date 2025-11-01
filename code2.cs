using System;

public class Employee

{

    private string name;

    private double salary;

    public string Name

    {

        get { return name; }

        set { name = value; }

    }



    public double Salary

    {

        get { return salary; }

        set

        {

            if (value < 0)

            {

                Console.WriteLine("Зарплата не может быть отрицательной!");

                salary = 0;

            }

            else if (value > 1_000_000)

            {

                Console.WriteLine("Зарплата не может превышать 1 000 000!");

                salary = 1_000_000;

            }

            else

            {

                salary = value;

            }

        }

    }

    public Employee(string name, double salary)

    {

        this.name = name;

        this.Salary = salary;

    }



    public Employee(string name) : this(name, 50000)

    {

    }

    public void Work()

    {

        Console.WriteLine($"{name} работает, зарплата: {salary}.");

    }

}



class Program

{

    static void Main(string[] args)

    {

        Employee employee1 = new Employee("Иван", 80000);

        Employee employee2 = new Employee("Анна");

        employee1.Work();

        employee2.Work();

        Console.WriteLine("\nПопытка задать отрицательную зарплату:");

        Employee employee3 = new Employee("Петр", -1000);

        employee3.Work();

    }

}