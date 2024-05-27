namespace assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int res = 0, n1, n2, ch;
            do
            {
                Console.WriteLine("1.addition");
                Console.WriteLine("2.substraction");
                Console.WriteLine("3.multiplication");
                Console.WriteLine("4.division");

                ch = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number 1");
                n1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the number 2");
                n2 = Convert.ToInt32(Console.ReadLine());


                if (ch == 1)
                {
                    res = n1 + n2;
                    Console.WriteLine("Addition is " + res);
                }
                else if (ch == 2)
                {
                    res = n1 - n2;
                    Console.WriteLine("substraction is " + res);

                }
                else if (ch == 3)
                {
                    res = n1 * n2;
                    Console.WriteLine("multiplication is " + res);
                }
                else
                {

                    res = n1 / n2;
                    Console.WriteLine("division is " + res);
                }

            } while (ch != 5);
            {
                Console.WriteLine("Wrong input");
            }

        }
    }
}
