namespace Core_Console.Shared
{
    public class Animal
    {
        public Animal() :
            this("", 0)
        {
        }

        public Animal(string name, int age)
        {
            Count = 0;
            Name = "";
            Age = 0;
        }

        public Animal(int count, string name, int age)
        {
            Count = count;
            Name = name;
            Age = age;
        }

        #region Properties

        public int Count { get; set; }
        
        public string Name { get; set; }
        public int Age { get; set; }
        #endregion

    }
}