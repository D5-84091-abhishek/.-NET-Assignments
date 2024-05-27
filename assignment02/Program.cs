namespace assignment02
{
    class Program1
    {
        int res1 = 0;

        public void add(int x, int y)
        {
            res1 = x + y;
            Console.WriteLine("Addition is " + res1);
        }
        public void sub(int x, int y)
        {
            res1 = x - y;
            Console.WriteLine("substraction is " + res1);

        }



        public void mul(int x, int y)
        {
            res1 = x * y;
            Console.WriteLine("multiplication is " + res1);

        }
        public void div(int x, int y)
        {
            res1 = x / y;
            Console.WriteLine("division is " + res1);

        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int ch, n1, n2, res = 0;
            Program1 p1 = new Program1();

            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Substraction");
            Console.WriteLine("3.Multiplication");
            Console.WriteLine("4.Division");
            Console.WriteLine("Enter Your choice");

            ch = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 1");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2");
            n2 = Convert.ToInt32(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    p1.add(n1, n2);

                    break;
                case 2:
                    p1.sub(n1, n2);
                    break;
                case 3:
                    p1.mul(n1, n2);
                    break;
                case 4:
                    p1.div(n1, n2);
                    break;
                default:
                    Console.WriteLine("You entered wrong choice");
                    break;
            }

        }
    }
}
