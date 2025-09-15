// See https://aka.ms/new-console-template for more information

var animal = new Animal("Generic Animal", 5);
animal.Speak();
Animal dog = new Dog("Buddy", 3, "Golden Retriever");
dog.Speak();
var cat = new Cat("Whiskers", 2, "Tabby");
cat.Speak();
dog.Speak();
var dog2 = new Dog("New dog", 1, "ab");
dog2.Breed = "ab";
dog2.Speak();
dog2.Speak();
dog2.Breed = "new";
dog2.Speak();


Console.WriteLine("");


public class Animal
{
    protected string Name { get; set; }
    protected int Age { get; set; }
    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public virtual void Speak()
    {
        Console.WriteLine($"{Name} says hello!");
    }
}

public class Dog : Animal
{
    private string breed;
    public Dog(string name, int age, string breed) : base(name, age)
    {
        this.Breed = breed;
    }

    public string Breed
    {
        get
        {
            return "This dog Breed is "+ breed;
        }
        set
        {
            if (value.Length <= 2)
            {
                throw new Exception("The breed need to be more than 2 char.");
            }
            breed = value;
        }
    }

    public void Bark()
    {
        Console.WriteLine($"{Name} barks!");
    }

    public void Hello()
    {
        Console.WriteLine($"{Name} say Hello, I'm, {Age}!");
    }

    public override void Speak()
    {
       Console.WriteLine($"My breed is {breed}");
    }
}

public class Cat : Animal
{
    private string color;
    public Cat(string name, int age, string color) : base(name, age)
    {
        this.color = color;
    }
    public void Meow()
    {
        Console.WriteLine($"{Name} meows!");
    }
}
