using TMS_11_Generics;

internal class Program
{
    internal class Pair<A, B>
    {
        public A firstVal;
        public B secondVal;
        public Pair(A firstValue, B secondValue)
        {
            this.firstVal = firstValue;
            this.secondVal = secondValue;
        }
    }
    private static void Main(string[] args)
    {
        Pair<string, int> pair = new Pair<string, int>("Hello", 12);
        Console.WriteLine($"A = {pair.firstValue}, B = {pair.secondValue}");
        Console.ReadLine();

    }
}