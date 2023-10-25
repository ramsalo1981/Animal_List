namespace AnimalList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();


            while (true)
            {
                var animal = new Animal();
                Console.Write("Enter animal name, type exit to exit: ");
                string input = Console.ReadLine();

                if (input == "exit")
                {
                    break;
                }
                else
                {
                    animal.Name = input;

                    Console.Write("Enter the number of legs: ");
                    input = Console.ReadLine();
                    animal.NumberOfLegs = int.Parse(input);

                    animals.Add(animal);

                }


            }
            foreach (var item in animals)
            {
                Console.WriteLine(item);
            }


        }
    }
    class Animal
    {
        public string Name { get; set; }
        public int NumberOfLegs { get; set; }

        public override string ToString()
        {
            return $"The {Name} has {NumberOfLegs} legs";
        }
    }
}