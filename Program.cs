using LAB_7;

namespace LAB_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<Employee> employeeStack = new Stack<Employee>();
            Employee employee1 = new Employee(1, "Emma", "Female", 21000);
            Employee employee2 = new Employee(2, "Gretchen", "Female", 11000);
            Employee employee3 = new Employee(3, "Noah", "Male", 40000);
            Employee employee4 = new Employee(4, "Greta", "Female", 21000);
            Employee employee5 = new Employee(5, "Anton", "Male", 45000);
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            foreach (var employee in employeeStack)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Items in stack = {employeeStack.Count}");
            }
            Console.WriteLine("------------------------");

            while (employeeStack.Count > 0)
            {
                var employee = employeeStack.Pop();
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in stack = {employeeStack.Count}");
            }
            Console.WriteLine("------------------------");

            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);

            Console.WriteLine($"StackCount after pushing all items to the stack: {employeeStack.Count}");

            Console.WriteLine("------------------------");

            var firstPeek = employeeStack.Peek();
            var secondPeek = employeeStack.Peek();
            Console.WriteLine(firstPeek);
            Console.WriteLine(secondPeek);

            Console.WriteLine("------------------------");

            if (employeeStack.Contains(employee3))
            {
                Console.WriteLine($"Employee number {employee3.ID} is in the stack.");
            }

            Console.WriteLine("------------------------");

            List<Employee> employeeList = new();
            foreach (Employee employee in employeeStack) {
                employeeList.Add(employee);
            }
            if (employeeList.Contains(employee2))
            {
                Console.WriteLine($"Employee2 object exists in the list");
            }
            else
            {
                Console.WriteLine($"Employee2 object does not exist in the list");
            }

            Console.WriteLine("------------------------");

            Employee? firstMale = employeeList.Find(e => e.Gender == "Male");
            Console.WriteLine(firstMale);

            Console.WriteLine("------------------------");

            List<Employee> allMales = employeeList.FindAll(e => e.Gender == "Male");
            foreach(Employee maleEmployee in allMales)
            {
                Console.WriteLine(maleEmployee);
            }
        }
    }
}
