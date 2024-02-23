using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Major : Student
{
    public Major(int id, string name) : base(id, name)
    {

    }
    public override void introduce()
    {
        Console.WriteLine("I am a student");
    }
}
