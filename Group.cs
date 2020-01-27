using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairedProgramming
{
    public class Group
    {
        public string Student1 { get; set; }
        public string Student2 { get; set; }
        public string Student3 { get; set; }

        public Group(string student1,string student2,string student3) {
            Student1 = student1;
            Student2 = student2;
            Student3 = student3;
        }
        public Group(string student1, string student2) {
            Student1 = student1;
            Student2 = student2;
        }
    }
}
