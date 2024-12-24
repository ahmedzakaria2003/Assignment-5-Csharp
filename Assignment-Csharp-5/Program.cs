namespace Assignment_Csharp_5
{
    internal class Program
    {
        #region q1
        static void PassByValue(int number)
        {
            number += 10;
            Console.WriteLine($"Inside PassByValue: number = {number}"); // Modified inside the method
        }

        // Method that takes value-type parameters by reference
        static void PassByReference(ref int number)
        {
            number += 10;
            Console.WriteLine($"Inside PassByReference: number = {number}"); // Modified inside the method
        }
        #endregion
        static void Main(string[] args)
        {

            #region q1
            int value = 20;

            // Pass by value example
            Console.WriteLine($"Before PassByValue: value = {value}");
            PassByValue(value);
            Console.WriteLine($"After PassByValue: value = {value}"); // Unchanged

            // Pass by reference example
            Console.WriteLine($"Before PassByReference: value = {value}");
            PassByReference(ref value);
            Console.WriteLine($"After PassByReference: value = {value}"); // Changed
            #endregion


        }
    }
}
