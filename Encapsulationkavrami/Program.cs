using System;

namespace Encapsulationkavrami
{
    internal class Program
    {
        static void Main(string[] args)
        {
        Student student = new Student();
        student.Name="Asli";
        student.Lastname = "Sen";
        student.No = 293;
        student.Classs = 3;

        student.passtheclass();
        student.GetStudentInfo();

        Student student2 = new Student();
        student2.Name="Deniz";
        student2.Lastname = "öz";
        student2.No = 345;
        student2.Classs = 1;

        student2.failtheclass();
        student2.failtheclass();
        student2.GetStudentInfo();

        }
    }

     class Student
    {
        private string name;
        private string lastname;
        private int no;
        private int classs;

     public string Name{get => name; set => name = value; }
     public string Lastname{get => lastname; set => lastname = value; }
     public int No{get => no; set => no = value; }
     public int Classs{get => classs; 
     set {
        if(value<1){
            Console.WriteLine("Class must be at least 1!");
            classs = 1;
            }
        else 
        classs = value;
     }
      }

  public Student(string name, string lastname, int no, int classs)
  { 
    Name= name;
    Lastname= lastname;
    No= no;
    Classs= classs;
  
  }

  public Student(){ }

public void GetStudentInfo()
        {
              Console.WriteLine("****************student's info******************");
            Console.WriteLine("Name of the student: {0}",this.Name);
            Console.WriteLine("Last Name of the student: {0}",this.Lastname);
            Console.WriteLine("Id of the student: {0}",this.No);
            Console.WriteLine("Class of the student: {0}",this.Classs);
        }

public void passtheclass(){
this.Classs = this.Classs+1;
}

public void failtheclass(){
this.Classs = this.Classs -1;
}
    }
}