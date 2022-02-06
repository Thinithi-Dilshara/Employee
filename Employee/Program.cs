using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] EmpId = new String[20];
            String[] EmpName = new String[20];
            int[] age = new int[20];
            String[] Department = new String[20];
            int num;
            Console.WriteLine("Enter the number of employees :- ");

            num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter employee ID : ");
                EmpId[i] = Console.ReadLine();

                Console.WriteLine("Enter employee name : ");
                EmpName[i] = Console.ReadLine();


                Agelabel:
                    Console.WriteLine("Enter employee age : ");
                    age[i] = int.Parse(Console.ReadLine());
                    if (age[i] < 18)
                    {
                        Console.WriteLine("Employee age cannot be less than 18");
                        goto Agelabel;
                    }

                Console.WriteLine("Enter employee department : ");
                Department[i] = Console.ReadLine();

                Console.WriteLine();
            }

            for (int j = 0; j < num; j++)
            {
                Console.WriteLine("Employee ID : " + EmpId[j]);
                Console.WriteLine("Employee name : " + EmpName[j]);
                Console.WriteLine("Employee age : " + age[j]);
                Console.WriteLine("Employee department : " + Department[j]);
                Console.WriteLine();
            }
        }
    }
}
