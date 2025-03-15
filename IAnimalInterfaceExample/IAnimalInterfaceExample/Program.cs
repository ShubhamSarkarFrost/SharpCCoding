namespace IAnimalInterfaceExample
{  
    interface IAnimal<T>
    {
        void MakeSound(T sound);
        void Eat(T foodQuantity);
    }

    class Dog : IAnimal<string>
    {
        public void MakeSound(string sound)
        {
            Console.WriteLine($"Dog Makes {sound} Sound");
        }

        public void Eat(string foodQuantity)
        {
            Console.WriteLine($"Dog Eats {foodQuantity} food");
        }
    }

    class Cat : IAnimal<int>
    {
        public void MakeSound(int times)
        {
            Console.WriteLine($"Cat meows {times} times.");
        }

        public void Eat(int foodQuantity)
        {
            Console.WriteLine($"Cat eats {foodQuantity} grams of food.");
        }
    }

    // Bird class implementing IAnimal<double>
    class Bird : IAnimal<double>
    {
        public void MakeSound(double pitch)
        {
            Console.WriteLine($"Bird chirps at {pitch} Hz.");
        }

        public void Eat(double foodQuantity)
        {
            Console.WriteLine($"Bird eats {foodQuantity} grams of seeds.");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dog example with string parameters
            IAnimal<string> myDog = new Dog();
            myDog.MakeSound("Woof Woof!");
            myDog.Eat("2 bowls");
            Console.WriteLine();

            // Cat example with int parameters
            IAnimal<int> myCat = new Cat();
            myCat.MakeSound(3);
            myCat.Eat(150);
            Console.WriteLine();

            // Bird example with double parameters
            IAnimal<double> myBird = new Bird();
            myBird.MakeSound(1500.5);
            myBird.Eat(50.75);
            Console.ReadKey();
        }
    }
}
