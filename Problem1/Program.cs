using System;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(Enum.Parse(typeof(Gender),"M"));
            Employee[] EmpArr = new Employee[3];
            for (int i = 0; i < 3; i++)
            {
               
                int ID = -1;
                while (ID < 1)
                {
                    Console.WriteLine("Enter ID: ");
                    String x = Console.ReadLine();
                    int val;
                    if(int.TryParse(x,out val) == true)
                    {
                        ID = val;
                        if (ID < 1) Console.WriteLine("Invalid ID, please try again");
                    }
                    else
                    {
                        Console.WriteLine("Invalid format, please try again");
                    }
                }
                
                
                int SL = -1;
                while (SL < 1 || SL > 15)
                {
                    Console.WriteLine("Enter Security Level: ");
                    String x = Console.ReadLine();
                    int val;
                    if (int.TryParse(x, out val) == true)
                    {
                        SL = val;
                        if (SL < 1 || SL > 15) Console.WriteLine("Invalid Security Level, please try again");
                    }
                    else
                    {
                        Console.WriteLine("Invalid format, please try again");
                    }
                }
         

                float Sal = -1;
                while (Sal < 200)
                {
                    Console.WriteLine("Enter Salary: ");
                    String x = Console.ReadLine();
                    float val;
                    if (float.TryParse(x, out val) == true)
                    {
                        Sal = val;
                        if (Sal < 200) Console.WriteLine("Invlid Salary Level, please try again");
                    }
                    else
                    {
                        Console.WriteLine("Invalid format, please try again");
                    }
                }
                String gen;
                Console.WriteLine("Enter Gender (M or m: for male & F or f: for female");
                gen = Console.ReadLine().ToUpper();
                while (gen != "F" && gen != "M")
                {
                    if (gen != "F" || gen != "M")
                        Console.WriteLine("Invalid Gender, Please Try Again: ");
                    Console.WriteLine("Enter Gender (M or m: for male & F or f: for female");
                    gen = Console.ReadLine().ToUpper();

                }
                Gender G = (Gender)Enum.Parse(typeof(Gender), gen);

                int d = -1, m = -1, y = -1;
                while (d <= 0 || d > 31 || m <= 0 || m > 12 || y <= 1900 || y > 2020)
                {
                    Console.WriteLine("Enter Hiredate:");
                    String HD = Console.ReadLine();
                    String[] arr = HD.Split('/');

                    if (arr.Length == 3)
                    {
                        int val;
                        d = arr[0] == null ? -1 : int.TryParse(arr[0], out val)? val : -1;

                        m = arr[1] == null ? -1 : int.TryParse(arr[1], out val)? val : -1;

                        y = arr[2] == null ? -1 : int.TryParse(arr[2], out val)? val : -1;
                    }

                    if (arr.Length != 3)
                        Console.WriteLine("Invalid Format");
                    else if (d <= 0 || d > 31)
                        Console.WriteLine("Invalid Day, Please try again");
                    else if (m <= 0 || m > 12)
                        Console.WriteLine("Invalid Month, Please try again");
                    else if (y <= 1900 || y > 2020)
                        Console.WriteLine("Invalid year, Please try again");
                }



                EmpArr[i] = new Employee(ID, SL, Sal, G, d, m, y);
                Console.WriteLine("");
                Console.WriteLine("You Entered: ");
                Console.WriteLine(EmpArr[i].ToString());
            }
        }
    }
}
