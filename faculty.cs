using System;

class Faculty : Person
{
  public string Id{ get; set; }
  public string Title{ get; set; }
  public virtual DateTime DateOfEmployment{ get; set; }
  public string Employer{ get; set; }
  public double YearlySalary { get; set; }
  public bool Tenured { get; set; }

public Faculty(){
  Title = "Instructor";
}

public Faculty(string FirstName, string LastName){
  Title = "Instructor";
}

public bool GrantTenure(){


if (DateTime.Today.Year - DateOfEmployment.Year > 5){
            Tenured = true;
            return Tenured;
    }
    else{
    Tenured = false;
    return Tenured;
    }
  }

public void Promote(){

if(Title == "Instructor" && (DateTime.Today.Date - DateOfEmployment.Date).Days > 2*365){
  Title = "Assistant Professor";
  Console.WriteLine("Faculty promoted to Assistant Professor rank");
}

else if(Title == "Assistant Professor" && (DateTime.Today.Date - DateOfEmployment.Date).Days > 5*365){
  Title = "Associate Professor";
  Console.WriteLine("Faculty promoted to Associate Professor rank");
}

else if(Title == "Associate Professor" && (DateTime.Today.Date - DateOfEmployment.Date).Days > 10*365){
  Title = "Professor";
  Console.WriteLine("Faculty promoted to Professor rank");
}

else if(Title == "Professor"){
  Console.WriteLine("No more promotion possible");
}
}

public override void Intro(){
  base.Intro();
  Console.WriteLine("I work as " + Title + " in " + Employer + " since " + DateOfEmployment.Year);
}




}