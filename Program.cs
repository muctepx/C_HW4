using System.Diagnostics;

namespace Sem_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 5, 7, 9, 11, 12, 14, 15, 16, 18, 19, 20, 22, 25 };
            int target1 = 32;

            HW.FindSumOfThreeNums1(arr1, target1);




            /*
       List<Student> list = new List<Student>();
       Student student = new Student();    
       student.FullName = "Alex";
       student.Age = 22;
       list.Add(student);
       student = new Student();
       student.FullName = "Max";
       student.Age = 20;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva";
       student.Age = 21;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva4";
       student.Age = 25;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva7";
       student.Age = 18;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva8";
       student.Age = 17;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva9";
       student.Age = 30;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva10";
       student.Age = 32;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva23";
       student.Age = 15;
       list.Add(student);
       student = new Student();
       student.FullName = "Eva25";
       student.Age = 40;
       list.Add(student);



       list = list.Skip(3).Take(5).Where(x=>x.Age>=20).OrderBy(x=>x.FullName).ToList();
       foreach (var item in list)
       {
           Console.WriteLine("Name: " + item.FullName + " Age= " + item.Age);
       }
      */


        }
    }
}
