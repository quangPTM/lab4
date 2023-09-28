
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("****Delegate example ****");
        MathOperations m = new MathOperations();
        SampleDelegate dlgt = m.Add;
        dlgt += m.Subtract;
        dlgt += m.Multiply;
        dlgt += m.Divide;
        dlgt(10, 90);
        Console.ReadLine();
    }
}