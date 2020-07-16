using System;

class Employee {
    //Fields
    private string firstname;
    private string lastname;
    private string id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private string employeestatus;
    private double yearlysalary;

/*
    //Properties
    public string Name{get; set;}//This is called auto implemented
    
    public int Age {get; set;}
      get{ return age; }
      set{
        if (value>=18)
          age = value;
        else
          age = 18;
      }
    }

    public double YearlySalary {get; set;}    
      get{ return yearlysalary; }
      set{
        if (value < 1000)
          yearlysalary = 1000;
        else
          yearlysalary = value;
      }
    }

*/
    public Employee()//Constructor with no parameters
    {
      id=0;
      age=0;
      firstname="unknown";
      lastname="unknown";

      Console.WriteLine("New employee created");
    }

    public Employee(string employeename, string employeelast, string employeeid, int employeeage, double employeesalary)//Constructor with parameters
    {
      firstname = employeename;
      lastname = employeelast;
      id = employeeid;
      age = employeeage;
      yearlysalary = employeesalary;
    }

    public void Intro()
    {
      Console.WriteLine("My name is " + firstname);
      Console.WriteLine("Last name " + lastname);
      Console.WriteLine("My id is " + id);
      Console.WriteLine("My age is " + age);
      Console.WriteLine("My yearly salary is $" + yearlysalary);
    }


/*
    public void RemoveEmployee()
    {
      Console.WriteLine("Checking employment status");
*/
    }

