namespace Question18
{
    public static class StaticMath
    {
        public static double Sum(double x, double y) => x + y;
        public static double Subtract(double x, double y) => x - y;
        public static double Multiply(double x, double y) => x * y;
        public static double Divide(double x, double y) => x / y;
    }

    public class InstanceMath
    {
        public double Sum(double x, double y) => x + y;
        public double Subtract(double x, double y) => x - y;
        public double Multiply(double x, double y) => x * y;
        public double Divide(double x, double y) => x / y;
    }

    internal class Program
    {
      
        // Delegate for Math operations
        public delegate double MathOperation(double x, double y);

        static void Main()
        {
            // Static Math class
            MathOperation staticSum = StaticMath.Sum;
            MathOperation staticSubtract = StaticMath.Subtract;
            MathOperation staticMultiply = StaticMath.Multiply;
            MathOperation staticDivide = StaticMath.Divide;

            // Uni-cast delegates
            Console.WriteLine($"Uni-cast delegates:");
            Console.WriteLine($"Static Sum: {staticSum(5, 3)}");
            Console.WriteLine($"Static Subtract: {staticSubtract(5, 3)}");
            Console.WriteLine($"Static Multiply: {staticMultiply(5, 3)}");
            Console.WriteLine($"Static Divide: {staticDivide(5, 3)}");

            // Multi-cast delegates
            MathOperation multiOp = staticSum + staticSubtract + staticMultiply + staticDivide;
            Console.WriteLine($"\nMulti-cast delegates:");
            foreach (MathOperation op in multiOp.GetInvocationList())
            {
                Console.WriteLine($"Result: {op(5, 3)}");
            }

            // Instance Math class
            InstanceMath instanceMath = new InstanceMath();
            MathOperation instanceSum = instanceMath.Sum;
            MathOperation instanceSubtract = instanceMath.Subtract;
            MathOperation instanceMultiply = instanceMath.Multiply;
            MathOperation instanceDivide = instanceMath.Divide;

            // Uni-cast delegates
            Console.WriteLine($"\nUni-cast delegates (Instance methods):");
            Console.WriteLine($"Instance Sum: {instanceSum(5, 3)}");
            Console.WriteLine($"Instance Subtract: {instanceSubtract(5, 3)}");
            Console.WriteLine($"Instance Multiply: {instanceMultiply(5, 3)}");
            Console.WriteLine($"Instance Divide: {instanceDivide(5, 3)}");

            // Multi-cast delegates
            MathOperation multiInstanceOp = instanceSum + instanceSubtract + instanceMultiply + instanceDivide;
            Console.WriteLine($"\nMulti-cast delegates (Instance methods):");
            foreach (MathOperation op in multiInstanceOp.GetInvocationList())
            {
                Console.WriteLine($"Result: {op(5, 3)}");
            }
        }
    }

}

