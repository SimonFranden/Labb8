//Simon Frändén(net22) Labb 8 
using System.Linq;

namespace Labb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new(1, "Janne", Employee.Gender.Male, 50000);
            Employee emp2 = new(2, "Eivor", Employee.Gender.Female, 60000);
            Employee emp3 = new(3, "Bruce", Employee.Gender.Male, 45000);
            Employee emp4 = new(4, "Alfred", Employee.Gender.Male, 55000);
            Employee emp5= new(5, "Celina", Employee.Gender.Female, 57000);

            //-----Del 1------
            Stack<Employee> empStack = new();
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);

            Console.WriteLine("---Skriv ut alla objekt---");
            foreach(var Employee in empStack)
            {
                Console.WriteLine($"{Employee.Id} - {Employee.Name} - {Employee._Gender} - {Employee.Salary}");
                Console.WriteLine("items left in stack: " + empStack.Count);
            }
            
            Console.WriteLine("\n---Hämta alla objekt med pop---");
            int iterations = empStack.Count;
            for (int i = 1; i <= iterations; i++)
            {
                Employee tempEmp = empStack.Pop();
                Console.WriteLine($"{tempEmp.Id} - {tempEmp.Name} - {tempEmp._Gender} - {tempEmp.Salary}");
                Console.WriteLine("items left in stack: " + empStack.Count);
            }
            empStack.Push(emp1);
            empStack.Push(emp2);
            empStack.Push(emp3);
            empStack.Push(emp4);
            empStack.Push(emp5);

            Console.WriteLine("\n---Peek---");
            iterations = 2;
            for (int i = 1; i <= iterations; i++)
            {
                Employee tempEmp = empStack.Peek();
                Console.WriteLine($"{tempEmp.Id} - {tempEmp.Name} - {tempEmp._Gender} - Employee.Salary");
                Console.WriteLine("items left in stack: " + empStack.Count);
            }
            Console.WriteLine("\n---Stack Contains--");
            Console.WriteLine("Stack contains emp3: " + empStack.Contains(emp3));

            //-----Del 2------
            List<Employee> empList = new();
            empList.Add(emp1);
            empList.Add(emp2);
            empList.Add(emp3);
            empList.Add(emp4);
            empList.Add(emp5);

            Console.WriteLine("\n---List Contains--");
            if (empList.Contains(emp2))
                {
                    Console.WriteLine($"{nameof(emp2)} object exists in the list");
                }
                else
                {
                    Console.WriteLine($"{nameof(emp2)} object does not exist in the list");
                }

            Console.WriteLine("\n---List Find--");
            Employee temp = empList.Find(x => x._Gender == Employee.Gender.Male);
            Console.WriteLine($"{temp.Id} - {temp.Name} - {temp._Gender} - {temp.Salary}");

            Console.WriteLine("\n---List Find All--");
            List<Employee> FindAllResult = new(empList.FindAll(x => x._Gender == Employee.Gender.Male));
            foreach(Employee e in FindAllResult)
            {
                Console.WriteLine($"{e.Id} - {e.Name} - {e._Gender} - {e.Salary}");
            }
        }
        


    }
}