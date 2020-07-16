  using System;

class MainClass {
  public static void Main (string[] args) {

    Employee unknown = new Employee();
    unknown.Intro();

    Employee employee2 = new Employee("Robert", "Downey", 12321, 12, 1000, "active");
    employee2.Intro();

    Employee employee3 = new Employee("John", "Smith", 50089, 38, 50000, "inactive");
    employee3.Intro();
    



  }
}