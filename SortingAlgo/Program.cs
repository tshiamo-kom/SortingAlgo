using System.Diagnostics;

namespace SortingAlgo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();

            Random rnd = new Random();
            for (int i = 0; i <= 999999; i++)
            {
                numbers.Add(rnd.Next(1, 10000));
            }

            Console.WriteLine("++++Before Sort++++");

            BubbleSort(numbers);
            SelectionSort(numbers);
            InsertionSort(numbers);

            Console.WriteLine("\n+++After Sort+++");

            List<Employee> empList = new List<Employee>()
            {
                new Employee("1001", "Smith"),
                new Employee("1002", "Williams"),
                new Employee("1003", "Jones"),
                new Employee("1004", "Specter"),
                new Employee("1005", "Federer")
            };

            Console.WriteLine("Employee data\n");
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp.ToString());
            }
            Console.WriteLine("\nAfter the sort");
            BubbleSort(numbers);
            foreach (Employee emp in empList)
            {
                Console.WriteLine(emp.ToString());
            }
            Console.Read();
        }

        private static void InsertionSort(List<int> ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = (i + 1); j > 0; j--)
                {
                    if (ar[j - 1] > ar[j])
                    {
                        int temp = ar[j - 1];
                        ar[j - 1] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            stw.Stop();
            Console.WriteLine("Insertion Sort: " + stw.ElapsedMilliseconds.ToString());
        }

        private static void SelectionSort(List<int> ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            int min;

            for (int i = 0; i < ar.Count - 1; i++)
            {
                min = i; // set position with min value
                for (int j = (i + 1); j < ar.Count; j++)
                {
                    if (ar[j] < ar[min]) // 
                    { min = j; }
                }
                //Swap value at min position with the current position of i
                int temp = ar[i];
                ar[i] = ar[min];
                ar[min] = temp;
            }
            stw.Stop();
            Console.WriteLine("Selection Sort: " + stw.ElapsedMilliseconds.ToString());
        }


        private static void BubbleSort(List<Employee> empList)
        {
            for (int i = 0; i < empList.Count - 1; i++)
            {
                for (int j = (i + 1); j < empList.Count; j++)
                {
                    if (empList[i].departId > empList[j].departId)
                    {
                        Employee temp = empList[i];
                        empList[i] = empList[j];
                        empList[j] = temp;
                    }
                }
            }
        }

        private static void BubbleSort(List<int> ar)
        {
            Stopwatch stw = new Stopwatch();
            stw.Start();
            for (int i = 0; i < ar.Count - 1; i++)
            {
                for (int j = (i + 1); j < ar.Count; j++)
                {
                    if (ar[i] > ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
            }
            stw.Stop();
            Console.WriteLine("Bubble Sort: " + stw.ElapsedMilliseconds.ToString());
        }

        private static void DisplayElements(List<int> numbers)
        {
            foreach (int num in numbers)
            {
                Console.Write(num + " ");
            }

        }
    }
}