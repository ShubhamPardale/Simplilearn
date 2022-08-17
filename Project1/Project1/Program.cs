using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace Project1
{
    class RainbowSchoolSystem
    {
        public static void Main(string[] args)
        {
            string path = @"C:\Users\shubham.pardale\Documents\GitHub\Simplilearn\Project1\Project1\RainbowSchoolData.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(path).ToList();
            Console.Write("1.View 2.Insert 3.Delete 4.Update\nENter your choice number: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    foreach (String line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    break;

                case 2:
                    Console.Write("Enter all the Data(ID Name class/section): ");
                    string data = Console.ReadLine();
                    lines.Add(data);
                    File.WriteAllLines(path, lines);
                    foreach (String line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Data Added Successfully!");
                    break;

                case 3:
                    Console.Write("Enter the ID number: ");
                    string id = Console.ReadLine();
                    foreach (String line in lines)
                    {
                        if (line.Trim().StartsWith(id))
                        {
                            lines.Remove(line);
                            File.WriteAllLines(path, lines);
                            break;
                        }
                    }
                    foreach (String line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Data Deleted Successfully!");
                    break;


                case 4:
                    Console.Write("Enter the ID number: ");
                    string UpdateId = Console.ReadLine();
                    foreach (String line in lines)
                    {
                        if (line.Trim().StartsWith(UpdateId))
                        {
                            lines.Remove(line);
                            Console.Write("Enter a the Data(ID Name class/section): ");
                            string UpdatedData = Console.ReadLine();
                            lines.Add(UpdatedData);
                            File.WriteAllLines(path, lines);
                            break;
                        }
                    }

                    foreach (String line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    Console.WriteLine("Data Updated Successfully!");
                    break;

            }

        }
    }
}

