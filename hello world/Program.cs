namespace hello_world
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            string stg = "Hello World!";
            Console.WriteLine(stg);

            Console.WriteLine("Enter username");
            string username = Console.ReadLine();
            Console.WriteLine("enters user age"); 
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("username is:" + username + "and the age is:" + age); 

        }
    }
}