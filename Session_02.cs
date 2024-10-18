namespace NguyenVuThanhGiang_31231026898
{
    internal class Session_02
    {
        public static void Main1(string[] args)
        {
            Question_01();
            Question_02();
            Question_03();
            Question_04();
            Question_05();
            Question_06();
            Question_07();
            Question_08();
            Question_09();
            Question_10();
        }
        public static void Question_01()
        {
            Console.Write("Enter number a =");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter number b=");
            int b = int.Parse(Console.ReadLine());
            int sum = a + b;
            Console.WriteLine($"a+b= {sum}");
        }
        public static void Question_02()
        {
            Console.Write("Enter the first variable:");
            int first = int.Parse(Console.ReadLine());
            Console.Write("Enter the second variable:");
            int second = int.Parse(Console.ReadLine());
            int temp;
            temp = first;
            first = second;
            second = temp;
            Console.WriteLine($"The first variable after swapping: {first}");
            Console.WriteLine($"The second variable after swapping: {second}");
        }
        public static void Question_03()
        {
            Console.Write("Enter the first number:");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Enter the second number:");
            double b = double.Parse(Console.ReadLine());
            double product = a * b;
            Console.WriteLine($"a * b = {product}");
        }
        public static void Question_04()
        {
            Console.Write("Enter the length in feet:");
            double a = double.Parse(Console.ReadLine());
            double b = a * 0.3048;
            Console.WriteLine($"{a} feet is equal to {b} meters");
        }
        public static void Question_05()
        {
            Console.WriteLine("Temperature Converter:");
            Console.WriteLine("1. Celcius to Farenheit");
            Console.WriteLine("2. Farenheit to Celcius");
            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Enter temperature in Celcius:");
                double a = double.Parse(Console.ReadLine());
                double b = (a * 9 / 5) + 32;
                Console.WriteLine($"{a} degree celcius is equal to {b} Farenheit");

            }
            else if (choice == 2)
            {
                Console.Write("Enter temperature in Farenheit:");
                double c = double.Parse(Console.ReadLine());
                double d = (c - 32) * 5 / 9;
                Console.WriteLine($"{c} Farenheit is equal to {d} degrees celcius");
            }
        }
        public static void Question_06()
        {
            Console.WriteLine("Size of data types in bytes:");
            Console.WriteLine($"Size of bool: {sizeof(bool)} bytes");
            Console.WriteLine($"Size of char: {sizeof(char)} bytes");
            Console.WriteLine($"Size of long: {sizeof(long)} bytes");
            Console.WriteLine($"Size of float: {sizeof(float)} bytes");
            Console.WriteLine($"Size of double: {sizeof(double)} bytes");
        }
        public static void Question_07()
        {
            Console.Write("Enter a character:");
            char a = char.Parse(Console.ReadLine());
            int b = (int)a;
            Console.WriteLine($"The ASCII value of {a} is {b}");

        }
        public static void Question_08()
        {
            const double pi = 3.14;
            Console.Write("Enter the radius: ");
            double radius = double.Parse(Console.ReadLine());
            double area = radius * radius * pi;
            Console.WriteLine($"The area of the circle is: {area}");
            
        }
        public static void Question_09()
        {
            Console.Write("Enter the square edge:");
            double edge = double.Parse(Console.ReadLine());
            double area = edge * edge;
            Console.WriteLine($"The area of square is: {area}");
        }
        public static void Question_10()
        {
            Console.Write("Enter the number of days:");
            int days = int.Parse(Console.ReadLine());
            int years = days / 365;
            int days_in_week = days - years * 365;
            int weeks = days_in_week / 7;
            int remainingdays = days_in_week % 7;
            Console.WriteLine($"{days} days is equal to {years} years, {weeks} weeks, {remainingdays} days");
        }
    }
}
