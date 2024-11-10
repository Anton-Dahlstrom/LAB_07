using LAB_7;

namespace LAB_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make the employee objects and push them to the stack.
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

            // Print each employee to the console.
            foreach (var employee in employeeStack)
            {
                Console.WriteLine(employee);
                Console.WriteLine($"Items in stack = {employeeStack.Count}");
            }
            Console.WriteLine("------------------------");

            // Pop and print each employee in the stack.
            while (employeeStack.Count > 0)
            {
                var employee = employeeStack.Pop();
                Console.WriteLine(employee);
                Console.WriteLine($"Items left in stack = {employeeStack.Count}");
            }
            Console.WriteLine("------------------------");

            // Push all employees back to the stack.
            employeeStack.Push(employee1);
            employeeStack.Push(employee2);
            employeeStack.Push(employee3);
            employeeStack.Push(employee4);
            employeeStack.Push(employee5);
            Console.WriteLine($"StackCount after pushing all items to the stack: {employeeStack.Count}");

            Console.WriteLine("------------------------");
            
            // Peek without removing items from the stack.
            var firstPeek = employeeStack.Peek();
            Console.WriteLine($"Peeking at {firstPeek}. There are {employeeStack.Count} items left in the stack.");
            var secondPeek = employeeStack.Peek();
            Console.WriteLine($"Peeking at {secondPeek}. There are {employeeStack.Count} items left in the stack.");

            Console.WriteLine("------------------------");

            // Check if employeeStack contains employee3.
            if (employeeStack.Contains(employee3))
            {
                Console.WriteLine($"Employee number {employee3.ID} is in the stack.");
            }

            Console.WriteLine("------------------------");
    
            // Add all employees to the employeeList.
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
            Console.WriteLine(employeeList.Count);

            Console.WriteLine("------------------------");
            
            // Query for the first male employee in the list.
            Employee? firstMale = employeeList.Find(e => e.Gender == "Male");
            Console.WriteLine(firstMale);

            Console.WriteLine("------------------------");
            
            // Query for all male employees in the list.
            List<Employee> allMales = employeeList.FindAll(e => e.Gender == "Male");
            foreach(Employee maleEmployee in allMales)
            {
                Console.WriteLine(maleEmployee);
            }
        }
    }
}
