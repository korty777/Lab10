using System;



class Animal

{

    private string name;



    public string Name

    {

        get { return name; }

        set { name = value; }

    }



    public Animal(string name)

    {

        this.name = name;

    }



    public void Speak()

    {

        Console.WriteLine($"{name} издаёт звук.");

    }

}



class Dog : Animal

{

    private int lives;



    public int Lives

    {

        get { return lives; }

        set

        {

            if (value < 1 || value > 9)

            {

                Console.WriteLine("Количество жизней должно быть от 1 до 9!");

            }

            else

            {

                lives = value;

            }

        }

    }



    public Dog(string name, int lives) : base(name)

    {

        Lives = lives;

    }



    public Dog(string name) : this(name, 9)

    {

    }



    public void Bark()

    {

        if (lives > 1)

        {

            lives--;

        }

        Console.WriteLine($"{Name} гавкнул, осталось жизней: {lives}.");

    }

}



class Program

{

    static void Main()

    {

        Dog volt = new Dog("Вольт", 8);

        volt.Speak();

        volt.Bark();



        Dog nordi = new Dog("Норди");

        nordi.Speak();

        nordi.Bark();



        Dog badDog = new Dog("Гром", 15);



        Console.ReadLine();

    }

}