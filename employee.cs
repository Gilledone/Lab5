using System;

class Employee {
    //Fields
    private string firstname;
    private string lastname;
    private int id;
    private int age;
    private string address;
    private string phonenumber;
    private string title;
    private string employmentstatus;
    private double yearlysalary;

    public int Age {
      get{ return age; }
      set{
        if (value>=18)
        age = value;
        else
      {
        age=18;
        Console.WriteLine("Age cannot be under 18");      
      }
    }
  }

    public double YearlySalary {
      get{ return yearlysalary; }
      set{
        if (value>=1000)
        yearlysalary = value;
        else
        {
          yearlysalary=1000;
          Console.WriteLine("Salary cannot be less than 1000");
        }
      }
    }



    public Employee()//Constructor with no parameters
    {
      id=0;
      Age=0;
      firstname="unknown";
      lastname="unknown";
      employmentstatus="inactive";

      Console.WriteLine("New employee created");
    }

    public Employee(string employeename, string employeelast, int employeeid, int employeeage, double employeesalary, string employeestatus)//Constructor with parameters
    {
      firstname = employeename;
      lastname = employeelast;
      id = employeeid;
      Age = employeeage;
      yearlysalary = employeesalary;
      employmentstatus = employeestatus;
    }

    public void Intro()
    {
      Console.WriteLine("My name is " + firstname);
      Console.WriteLine("Last name " + lastname);
      Console.WriteLine("My id is " + id);
      Console.WriteLine("My age is " + Age);
      Console.WriteLine("My yearly salary is $" + yearlysalary);
      Console.WriteLine("My status is " + employmentstatus);
    }


    public void RemoveEmployee() {
      if (employmentstatus = active)
      employmentstatus = active;
      else{
        
      }
    

    }
    

