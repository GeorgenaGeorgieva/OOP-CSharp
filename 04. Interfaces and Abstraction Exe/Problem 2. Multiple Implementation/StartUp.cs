namespace PersonInfo
{
	using System;

    public class StartUp
    {
        public static void Main(string[] args)
        {
	    try
	    {
		var name = Console.ReadLine();
		var age = int.Parse(Console.ReadLine());
		var id = Console.ReadLine();
		var birthdate = Console.ReadLine();

		var citizen = new Citizen(name, age, id, birthdate);
		Console.WriteLine(citizen);
	    }
	    catch (ArgumentException exception)
	    {
		Console.WriteLine(exception.Message);	
	    }
        }
    }
}
