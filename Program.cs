using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> students = new List<string>();
            bool flag = true;

            do
            {
                string x;


                Console.WriteLine("Enter a Name! or press \"n\" to cancel");
                x = Console.ReadLine();
                if (x != "n")
                {
                    students.Add(x);
                }
                else
                {
                    flag = false;
                }
                //Console.Read(students);
            } while (flag);
            
            foreach (string x in students)
            {
                Console.WriteLine(x);
            }
            List<Group> groups = new List<Group>();

            if (students.Count % 2 != 0)
            {
                groups.Add(new Group(students[0], students[1], students[2]));
                for (int i = 3; i < students.Count; i += 2)
                {
                    groups.Add(new Group(students[i], students[i + 1]));
                }
            }

            for (int i = 0; i < students.Count; i+=2)
            {
                groups.Add(new Group(students[i], students[i + 1]));
            }
        }
    }
}
