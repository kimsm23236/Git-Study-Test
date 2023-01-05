using System;

namespace TestProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // 오류가 날 일이 없는 포인트를 저장해 놓는것이 중요

            // 바꿈

            // { 2023.01.05. Add new feature user input
            string userInput = string.Empty;
            Console.WriteLine("This program convert Cm to Inch");
            Console.Write("Input Cm Value : ");
            userInput = Console.ReadLine();

            int cmInput = 0;
            int.TryParse(userInput, out cmInput);

            Ruler ruler = new Ruler(cmInput);
            // } 2023.01.05. Add new feature user input
            ruler.Run();
        }
    }

    public class Ruler
    {
        private const float ONE_INCH = 2.54f;
        public int Centimeter { get; set; } = 0;
        public float Inch
        {
            get { return Centimeter * ONE_INCH; }
            private set { Centimeter = (int)(value / ONE_INCH); }
        }
        public Ruler(int cmValue)
        {
            Centimeter = cmValue;
        }

        public void Run()
        {
            Console.WriteLine($"{this.Centimeter}cm 는 {Inch}inch 입니다.");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            // 오류가 날 일이 없는 포인트를 저장해 놓는것이 중요
            Console.WriteLine("Hello, World!");
            // 바꿈

            Ruler ruler = new Ruler(10);
            ruler.Run();
        }
    }

    
}