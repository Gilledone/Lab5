  using System;

class MainClass {
  public static void Main (string[] args) {

    Employee unknown = new Employee();//constructor with no parameters
    unknown.Intro();

    Employee employee2 = new Employee("Robert", "Downey", 12321, 12, 1000);
    employee2.Intro();

    Employee employee3 = new Employee("John", "Smith", S0089, 38, 50000);
    employee3.Intro();
   /*
    Employee employee1 = new Employee("employee1", 1111, -3);
    //constructor with parameters
    employee1.Intro();
    */
  }
}