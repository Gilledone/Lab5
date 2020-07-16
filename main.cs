  using System;

class MainClass {
  public static void Main (string[] args) {

    Employee unknown = new Employee();//constructor with no parameters
    unknown.Intro();

    Employee employee2 = new Employee("Robert", "Downey", 12321, 12);
    employee2.Intro();
   /*
    Employee employee1 = new Employee("employee1", 1111, -3);
    //constructor with parameters
    employee1.Intro();
    */
  }
}