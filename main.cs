using System;


class MainClass {
  public static void Main (string[] args) {
    
    /*Console.WriteLine("Testing Address");
    Address addr1 = new Address();
    addr1.AddressLine1="1234 Main St";
    addr1.AddressLine2="Apt 102";
    addr1.City = "Cleveland";
    addr1.State = "azzffdsfd";
    addr1.Zipcode = "44143";

    addr1.Display();*/

    /*Console.WriteLine("Testing Person");
    Person p1 = new Person();
    p1.FirstName = "John";
    p1.LastName = "Smith";
    p1.PermanentAddress.AddressLine1 = "1234 Main St";
    p1.PermanentAddress.City = "Cleveland";
    p1.PermanentAddress.State = "OH";
    p1.PermanentAddress.Zipcode = "44143";
    p1.DateOfBirth = Convert.ToDateTime("07/13/1994");
    p1.Intro();
    p1.IsBirthday();
    Console.WriteLine("");  */  
/*
    Console.WriteLine("Testing Student 1");
    Student s1 = new Student();
    s1.FirstName = "Kara";
    s1.LastName="Kaiser";
    s1.DateOfBirth = Convert.ToDateTime("01/01/2020");
    s1.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s1.PermanentAddress.City = "Parma";
    s1.PermanentAddress.State = "OH";
    s1.PermanentAddress.Zipcode = "44143";
    s1.GPA = 2.1;
    s1.School = "Cleveland State University";
    s1.Intro();
    s1.IsBirthday();
    s1.SetAcademicStanding();
    Console.WriteLine(s1.AcademicStanding);
    Console.WriteLine("");

    Console.WriteLine("Testing Student 2");
    Student s2 = new Student("Andrew", "Peggman");    
    s2.DateOfBirth = Convert.ToDateTime("01/01/1989");
    s2.PermanentAddress.AddressLine1 = "999 Mallard Dr";
    s2.PermanentAddress.City = "Parma";
    s2.PermanentAddress.State = "OH";
    s2.PermanentAddress.Zipcode = "44143";
    s2.GPA = 2.75;
    s2.School = "Ohio State University";
    s2.Intro();
    s2.IsBirthday();
    s2.SetAcademicStanding();
    Console.WriteLine(s2.AcademicStanding);
    Console.WriteLine("");
*/

    Console.WriteLine("Testing Employee 1");
    Faculty f1 = new Faculty();
    f1.FirstName = "Vlad";
    f1.LastName = "Yarosh";
    f1.DateOfBirth = Convert.ToDateTime("11/17/2001");
    f1.PermanentAddress.AddressLine1 = "7777 State Rd";
    f1.PermanentAddress.City = "Parma";
    f1.PermanentAddress.State = "OH";
    f1.PermanentAddress.Zipcode = "44562";
    f1.Employer = "Tri-C";
    f1.DateOfEmployment = Convert.ToDateTime("01/01/2015");
    f1.Intro();
    Console.WriteLine("");

    
    
    Console.WriteLine("Testing Employee 2");
    Faculty f2 = new Faculty();
    f2.FirstName = "Max";
    f2.LastName = "Vazovski";
    f2.DateOfBirth = Convert.ToDateTime("05/14/1995");
    f2.PermanentAddress.AddressLine1 = "5395 9th street";
    f2.PermanentAddress.City = "Clevelnad";
    f2.PermanentAddress.State = "OH";
    f2.PermanentAddress.Zipcode = "44193";
    f2.Employer = "CSU";
    f2.DateOfEmployment = Convert.ToDateTime("01/01/2016");
    f2.Intro();
    f2.Promote();
  }
}
