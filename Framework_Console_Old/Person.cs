namespace Framework_Console_Old
{
	internal class Person
	{
		public string Name { get; set; }
		public int Age { get; set; }

		public Person()
		{
			Name = "John";
			Age = 30;
		}

		public override string ToString()
		{
			return $"Name: {Name}, Age: {Age}";
		}
	}
}