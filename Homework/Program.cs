namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////          1         ////////////////////////////// 

            Console.WriteLine("\tAverage:");

            Console.Write("Enter first number:");
            double number1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter second number:");
            double number2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter third number:");
            double number3 = Convert.ToDouble(Console.ReadLine());

            double average = (number1 + number2 + number3) / 3;

            Console.Write("Average: ");
            Console.WriteLine(average);

            Console.WriteLine("\n");

            ///////////////////////////          2         //////////////////////////////

            Console.WriteLine("\tThe equation a * x + b = 0:");

            Console.Write("Enter number 'a': ");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number 'b': ");
            double b = Convert.ToDouble(Console.ReadLine());

            if (a == 0 && b == 0)
            {
                Console.WriteLine("Infinite number of solutions");
            }
            if (a == 0 || (b / a) != 0)
            {
                Console.Write("x = ");
                Console.WriteLine(-b / a);
            }

            Console.WriteLine("\n");

            /////////////////////////          3         //////////////////////////////

            Console.WriteLine("\tNumber in Power:");

            Console.Write("Enter number: ");
            double number = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter degree: ");
            double degree = Convert.ToDouble(Console.ReadLine());

            Console.Write("Number in to a power: ");
            Console.WriteLine(Math.Pow(number, degree));

            Console.WriteLine("\n");

            ///////////////////////          4         //////////////////////////////

            Console.WriteLine("\tSquare and length of circle:");

            double Pi = 3.14;

            Console.Write("Enter radius: ");
            double R = Convert.ToDouble(Console.ReadLine());

            double S = Pi * Math.Pow(R, 2);
            Console.Write("Square of a circle : ");
            Console.Write(S);
            Console.WriteLine(" m2");

            double L = 2 * Pi * R;
            Console.Write("Length of a circle : ");
            Console.Write(L);
            Console.WriteLine(" m");

            Console.WriteLine("\n");

            /////////////////////////          5         //////////////////////////////

            Console.WriteLine("\tCurrency Converter:");

            Console.Write("Enter quantity grivnas: ");
            double grvn = Convert.ToDouble(Console.ReadLine());

            double dllr = 41.00;
            Console.Write("Quantity dollars: ");
            Console.Write(grvn / dllr);
            Console.WriteLine(" USD");

            double euro = 43.10;
            Console.Write("Quantity euro: ");
            Console.Write(grvn / euro);
            Console.WriteLine(" EUR");

            double btc = 2727242.32;
            Console.Write("Quantity bitcoins: ");
            Console.Write(grvn / btc);
            Console.WriteLine(" BTC");

            Console.WriteLine("\n");

            /////////////////////////          6         //////////////////////////////

            Console.WriteLine("\tKilometers and miles:");

            Console.Write("Enter quantity km: ");
            double km = Convert.ToDouble(Console.ReadLine());

            double lml = 1.609;
            Console.Write("Quantity land miles: ");
            Console.Write(km / lml);
            Console.WriteLine(" ml");

            double nml = 1.852;
            Console.Write("Quantity nautical miles: ");
            Console.Write(km / nml);
            Console.WriteLine(" ml");

            Console.WriteLine("\n");

            /////////////////////////          7         //////////////////////////////

            Console.WriteLine("\tPercent of number:");

            Console.Write("Enter quantity precent: ");
            double p = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter number: ");
            double n = Convert.ToDouble(Console.ReadLine());

            double result = n * p / 100;
            Console.Write("Result:");
            Console.WriteLine(result);

            Console.WriteLine("\n");

            /////////////////////////          8         //////////////////////////////

            Console.WriteLine("\tCelsium and Fahrenheit:");

            Console.Write("Enter temp in celsium: ");
            double deg = Convert.ToDouble(Console.ReadLine());

            double F = (deg * 9 / 5) + 32;
            Console.Write("Temp fahrenheit: ");
            Console.WriteLine(F);

            Console.Write("Enter temp in fahrenheit: ");
            double degf = Convert.ToDouble(Console.ReadLine());
            double C = (degf - 32) * 5 / 9;
            Console.Write("Temp celsium: ");
            Console.WriteLine(C);

            Console.WriteLine("\n");
        }
    }
}
