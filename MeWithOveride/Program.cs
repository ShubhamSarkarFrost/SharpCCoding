namespace MeWithOveride
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dog bruno = new Dog();
            bruno.makeSound();

            Cat furry = new Cat();
            furry.makeSound();
        }
    }

    class Animal()
    {
        string sound = "Animal";

        public virtual void makeSound()
        {
            Console.WriteLine($"the Animal is making {sound} sound");
        }
    }

    class Dog(): Animal
    {
        string sound = "Bark Bark!!";

        public override void makeSound()
        {
            Console.WriteLine($"The Dog is making {sound} sound");
        }
    }

    class Cat(): Animal
    {
        string sound = "meou meou!!";

        public override void makeSound()
        {
            Console.WriteLine($"The Dog is making {sound} sound");
        }
    }
}
