using System;

namespace TestProject
{
    // { Alpha Branch Modified 2023 01 05
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
    // } Alpha Branch Modified 2023 01 05

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