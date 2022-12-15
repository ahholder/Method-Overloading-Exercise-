namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Example functions are below

            //Tested Functions Below
            /*Console.WriteLine(Add(1, 7));
            Console.WriteLine(Add(1.5, 2.75));
            Console.WriteLine(Add(1, 2, true));
            Console.WriteLine(Add(1, 2, false));*/
        }
        static int Add(int num1, int num2)
        {
            return num1 + num2;
        }
        static double Add(double num1, double num2)
        {
            return num1 + num2;
        }
        static string Add(int num1, int num2, bool param)
        {
            string result = "";
            int sum = num1 + num2;
            if (param == true)
            {
                result = $"{sum} dollar";
                if (sum != 1 && sum != -1) result += "s";
            }
            return result;
        }
    }
}
