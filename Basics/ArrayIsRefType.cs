namespace Basics
{
    internal class ArrayIsRefType
    {
        static void Main(string[] args)
        {
            int[] first = { 1, 2, 3, 4 };
            int[] second = first;

            second[0] = 99;
            Console.WriteLine(first[0]);

            // Checking both refering to same array
            // Way - 1
            bool areSame = object.ReferenceEquals(first, second);

            // Way - 2
            bool checkSame = first == second;
            Console.WriteLine(areSame);
            Console.WriteLine(checkSame);
        }
    }
}
