using System;



namespace Noutbok3

{

    internal class Device

    {

        private string brand;



        public string Brand

        {

            get { return brand; }

            set { brand = value; }

        }



        public Device(string brand)

        {

            Brand = brand;

        }



        public void PowerOn()

        {

            Console.WriteLine($"{brand} включён.");

        }

    }



    internal class Laptop : Device

    {

        private int ram;

        private int battery;



        public int Ram

        {

            get { return ram; }

            set

            {

                if (value >= 1 && value <= 64)

                {

                    ram = value;

                }



                else

                {

                    Console.WriteLine("ОЗУ должно быть от 1 до 64!");



                    if (value > 64)

                    {

                        ram = 64;

                    }



                    else

                    {

                        ram = 1;

                    }



                }

            }

        }



        public int Battery

        {

            get { return battery; }

            set

            {

                if (value >= 0 && value <= 100)

                {

                    battery = value;

                }



                else

                {

                    Console.WriteLine("Заряд батареи должен быть от 0 до 100!");



                    if (value > 100)

                    {

                        battery = 100;

                    }



                    else

                    {

                        battery = 0;

                    }



                }

            }

        }



        public Laptop(string brand, int ram, int battery) : base(brand)

        {

            Ram = ram;

            Battery = battery;

        }



        public void Work()

        {

            Console.WriteLine($"Ноутбук {Brand}, ОЗУ: {ram} ГБ, заряд: {battery}%.");

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            Laptop laptop = new Laptop("ASUS", 52, 42);

            laptop.PowerOn();

            laptop.Work();



            laptop.Ram = 0;

            laptop.Work();



            laptop.Battery = 150;

            laptop.Work();



            Console.ReadLine();

        }

    }

}