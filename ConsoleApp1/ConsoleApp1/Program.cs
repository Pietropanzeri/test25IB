namespace ConsoleApp1
{
    internal class Program
    {
        class Student
        {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Cognome { get; set; }

            public Student(Student student)
            {
                Id = student.Id;
                Name = student.Name;
                Cognome = student.Cognome;
            }
            public override string ToString()
            {
                return base.ToString(); 
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}