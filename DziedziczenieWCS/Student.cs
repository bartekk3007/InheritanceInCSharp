using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Student : Person
{
    public Student(int id, string name) : base(id, name)
    {

    }
    public override void introduce()
    {
        Console.WriteLine("I am a student");
    }
}
