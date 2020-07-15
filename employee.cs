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
    private string employeestatus;
    private double yearlysalary;


    //Properties
    public string Name{get; set;}//This is called auto implemented
    
    public int Age {get; set;}
        public int age {
      get{ return age; }
      set{
        if (value > 18)
          age = value;
        else
          age = 18;
      }
    }

    public double YearlySalary {get; set;}    
        public double yearlySalary {
      get{ return yearlysalary; }
      set{
        if (value < 1000)
          yearlysalary = 1000;
        else
          yearlysalary = value;
      }
    }


    public Employee()//Constructor with no parameters
    {
      Id="unknown";
      Age=0;
      Firstname="unknown";
      Lastname="unknown";

      Console.WriteLine("no parameters");
    }

    public Employee(string firstname, string lastname, int id, int age)//Constructor with parameters
    {
      Firstname = firstname;
      Lastname = lastname;
      Id = id;
      Age = age;      
      Console.WriteLine("parameters");
    }

    public void Intro()
    {
      Console.WriteLine("My name is " + Firstname);
      Console.WriteLine("Last name " + 0);
      Console.WriteLine("My id is " + Id);
      Console.WriteLine("My age is " + Age);
    }

    public void RemoveEmployee()
    {
      Console.WriteLine("Checking employment status");

    }

}