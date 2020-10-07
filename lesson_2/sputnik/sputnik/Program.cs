using System;

namespace sputnik
{
  public class Sputnik
    {
        private string name;
        private double speed;
        private bool isFly;
        private bool isTranslate;
        private string message;


        public Sputnik(string name)
        {
            this.name = name;
            speed = 0;
            isFly = false;
            isTranslate = false;
            message = "Empty message";
        }

        public void getLunding()
        {
            speed = 0;
            isFly = false;
            stopTranslate();
        }

        public void goToSpase()
        {
            isFly = true;
            speed = 100;
        }

        public void upSpeed(double upSpeed)
        {
            speed += upSpeed;
            if (speed <= 1000)
            {
                Console.WriteLine("The speed has increased");
            }
            else
            {
                speed -= upSpeed;
                Console.WriteLine("Speed is too hight");
            }
        }

        public void downSpeed(double downSpeed)
        {
            if (speed != 0 && speed > downSpeed)
            {
                speed -= downSpeed;
                Console.WriteLine("Speed ​​reduced"); 
            }
            else
            {
                Console.WriteLine("Speed = 0");
            }
        }

        public void startTranslate()
        {
            isTranslate = true;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(message);
                System.Threading.Thread.Sleep(1000);
            }
        }

        public void showMessage()
        {
            Console.WriteLine("Message: " + message);
        }
        public void stopTranslate()
        {
            isTranslate = false;
        }

        public void changeMessage()
        {
            Console.WriteLine("Please, change message");
            message = Console.ReadLine();
            Console.WriteLine("Message change");
        }

        public void getInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("His speed: " + speed);
            Console.WriteLine("His fly: " + isFly);
            Console.WriteLine("His translate: " + isTranslate);
        }

        public void action(int status)
        {
            switch(status)
            {
                case 1:
                    goToSpase();
                    Console.WriteLine($"The {name} took off");
                    break;
                case 2:
                    getLunding();
                    Console.WriteLine($"The {name} has landed");
                    break;
                case 3:
                    Console.Write("Enter speed: ");
                    double speed = Convert.ToDouble(Console.ReadLine());
                    upSpeed(speed);
                    break;
                case 4:
                    Console.Write("Enter speed: ");
                    double speed1 = Convert.ToDouble(Console.ReadLine());
                    downSpeed(speed1);
                    break;
                case 5:
                    Console.WriteLine("The broadcast has begun");
                    startTranslate();
                    break;
                case 6:
                    Console.WriteLine("The broadcast is over");
                    stopTranslate();
                    break;
                case 7:
                    changeMessage();
                    break;
                case 8:
                    showMessage();
                    break;
                case 9:
                    getInfo();
                    break;
                case 0:
                    break;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter name of sputnik: ");
            Sputnik firstSputnik = new Sputnik(Console.ReadLine());

            int status = 0;

            do
            {
                Console.WriteLine("1 - Takeoff");
                Console.WriteLine("2 - Landing");
                Console.WriteLine("3 - Increase speed");
                Console.WriteLine("4 - Slow down");
                Console.WriteLine("5 - Start broadcast");
                Console.WriteLine("6 - Stop broadcasting");
                Console.WriteLine("7 - Change the broadcast message");
                Console.WriteLine("8 - Show broadcast message");
                Console.WriteLine("9 - Show sputnik information");
                Console.WriteLine("0 - Finish the program");
                Console.WriteLine();

                Console.WriteLine("Enter next action");
                status = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                firstSputnik.action(status);
                Console.WriteLine();
            }
            while (status != 0);
            Console.WriteLine("Thank you for using our sputnik control system");

        }
    }
}