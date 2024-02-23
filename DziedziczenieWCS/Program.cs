class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World");
        Person p1 = new Person(1, "Osoba");
        p1.introduce();
        Major m1 = new Major(3, "Magister");
        m1.introduce();
    }
}