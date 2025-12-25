namespace Tutor.DataTypes
{
    internal class DataTypesQuizCOpilot
    {
        static void Main(string[] args)
        {
            // Ensure the application is not running when making changes to the code.  
            // ENC0097 occurs because live editing is not supported while the application is running.  
            // Stop the application, make the changes, and then restart it.  

            byte age = 25;
            int score = 150000;
            long target = 9121685836;

            float x = 1.5f;
            double pi = 3.14159;
            decimal price = 19.99m;

            // Corrected concatenation for better readability  
            Console.WriteLine("age: " + age);
            Console.WriteLine("score: " + score);
            Console.WriteLine("target: " + target);
            Console.WriteLine("x: " + x);
            Console.WriteLine("pi: " + pi);
            Console.WriteLine("price: " + price);
        }
    }
}
