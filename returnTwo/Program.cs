using returnTwo;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int usertemp = 0;
            int userhumi = 0;
            string scale = "";
            bool thekey = true;
            


            WeatherData Weather1 = new WeatherData(usertemp, userhumi, scale);
            

            Console.WriteLine("hello to the weatherdata converter EXSTREAM power 3000");

            Console.WriteLine("What SCALE wood you like to use type c for CELSIUS or f for FAHRENHEIT ");

            Console.Write("Enter your leter here: ");

           while (scale != "c" && scale != "f")
            {
              
                scale = Console.ReadLine();

                if (scale == "c" || scale == "f")
                {
                    Console.WriteLine($"scale has bin set to your perferd SCALE {scale} EXSTREAM!!!");
                    Weather1.scale = scale;
                    Console.WriteLine(Weather1.scale);
                }
                else
                {
                    Console.WriteLine("that is not what we asked lets try this agen EXSTREAM style");
                }
            }

            Console.WriteLine($"enter your temperature in {scale}");
            Console.Write("enter your temp here: ");

            while (thekey)
            {
                usertemp = int.Parse(Console.ReadLine());

                if (scale == "f")
                {
                    if (usertemp < -75 || usertemp > 140)
                    {
                        messgesOne();
                    }
                    else
                    {
                        messgesTwo();
                        Weather1.temperature = usertemp;
                        thekey = false;
                    }
                }
                else
                {
                    if (usertemp < -60 || usertemp > 60)
                    {
                        messgesOne();
                    }
                    else
                    {
                        messgesTwo();
                        Weather1.temperature = usertemp;
                        thekey = false;

                    }
                }
            }

            thekey = true;
            Console.Write("set Humidity here: ");

            while (thekey)
            {
                userhumi = int.Parse(Console.ReadLine());
                if (userhumi < 0 || userhumi > 100)
                {
                    messgesOne();
                } else
                {
                    Weather1.humidity = userhumi;
                    thekey=false;
                }
            }

            
            

            Console.WriteLine("switch the scales to eather f or c");
            Console.Write("enter the leter here: ");
            Weather1.convertor(Console.ReadLine());



            Console.WriteLine($"your temp in {scale} {Weather1.temperature}");
            Console.WriteLine($"your humidity is {Weather1.humidity}");




        

        }
        static void messgesOne()
        {
            Console.WriteLine("that is too EXSTREAM for this program");
            Console.Write("input another number DUDE!: ");
        }

        static void messgesTwo()
        {
            Console.WriteLine("that is some nice numbers dude!");
        }
        

    }
}