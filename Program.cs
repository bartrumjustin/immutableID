namespace immutableID
{
    public record class Student
    {
        // auto-implemented properties
        public int Id { get; init; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // default constructor
        public Student()
        {
            Id = 0;
            FirstName = "";
            LastName = "";
        }
        // parameterized constructor
        public Student(int i, string First, string Last)
        {
            Id = i;
            FirstName = First;
            LastName = Last;
        }
        //2nd param const with Id only
        public Student(int i)
        {
            Id = i;
            FirstName = string.Empty;
            LastName = string.Empty;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student param = new(001);
            param.FirstName = "joe";
            param.LastName = "watson";
            Console.WriteLine(param);
            Student param2 = new(002, "john", "doe");
            Console.WriteLine(param2);
        }
    }
}
