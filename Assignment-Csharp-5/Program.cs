namespace Assignment_Csharp_5
{
 
    internal class Program
    {
        #region q1
        //static void PassByValue(int number)
        //{
        //    number += 10;
        //    Console.WriteLine($"Inside PassByValue: number = {number}"); // Modified inside the method
        //}

        //// Method that takes value-type parameters by reference
        //static void PassByReference(ref int number)
        //{
        //    number += 10;
        //    Console.WriteLine($"Inside PassByReference: number = {number}"); // Modified inside the method
        //}
        #endregion
        #region q2
        class Person
        {
            public string Name;
        }
        // Pass by value (reference type)
        static void PassByValue(Person person)
        {
            person.Name = "John";  // Modifies the object's state (Name)
            person = new Person(); // Creates a new object, doesn't affect the original reference
            person.Name = "Alice"; // Modifies the new object
            Console.WriteLine("Inside PassByValue: " + person.Name);
        }

        // Pass by reference (reference type)
        static void PassByReference(ref Person person)
        {
            person.Name = "Mike";  // Changes the Name
            person = new Person(); // Changes the original reference
            person.Name = "Sarah";
            Console.WriteLine("Inside PassByReference: " + person.Name);
        }
        #endregion
        static void Main(string[] args)
        {

            #region q1
            //int value = 20;

            //// Pass by value example
            //Console.WriteLine($"Before PassByValue: value = {value}");
            //PassByValue(value);
            //Console.WriteLine($"After PassByValue: value = {value}"); // Unchanged

            //// Pass by reference example
            //Console.WriteLine($"Before PassByReference: value = {value}");
            //PassByReference(ref value);
            //Console.WriteLine($"After PassByReference: value = {value}"); // Changed
            #endregion
            #region q2
            //// Example for Pass by Value
            //Person person1 = new Person { Name = "David" };
            //Console.WriteLine("Before PassByValue: " + person1.Name); // David
            //PassByValue(person1); // Passes a copy of the reference
            //Console.WriteLine("After PassByValue: " + person1.Name); // David (reference in Main is unchanged)
            //// Pass by reference example
            //Person person2 = new Person { Name = "David" };
            //Console.WriteLine("Before PassByReference: " + person2.Name);
            //PassByReference(ref person2); // Changes the original reference to a new object
            //Console.WriteLine("After PassByReference: " + person2.Name); // Name is now "Sarah"

            #endregion
            #region q3
            //public static (int ,int) SumSub(int x ,int y, ref  int sum, ref  int sub)
            //{
            //    sum = x + y;
            //    sub = x - y;
            //    return (sum, sub);

            //}
            #endregion
            #region q4
            //static int SumDigits(int num)
            //{
            //    int result = 0;
            //    while (num > 0)    // 543
            //    {
            //        result += num % 10;
            //        num /= 10;
            //    }
            //    return result;

        }
        #endregion

    }
    }
}
