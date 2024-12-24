namespace Assignment_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Describe the difference between passing reference type parameters by value and by reference, with a C# example.

            /*
            -- Passing by value: The method receives a copy of the reference.
               Changes made to the object's properties inside the method will affect the original object since 
               both the original and copied references point to the same memory location.

            -- Passing by reference: The method receives the actual reference, not a copy.
               This allows the method to modify the reference itself, such as pointing it to a new object. 
               Such changes will be reflected outside the method.
            */

            // Example
            //int[] numbers = { 1, 2, 3 };

            //// Passing by value
            //ModifyByValue(numbers);
            //Console.WriteLine("After ModifyByValue: " + string.Join(", ", numbers)); // Output: 10, 2, 3

            //// Passing by reference
            //ModifyByReference(ref numbers);
            //Console.WriteLine("After ModifyByReference: " + string.Join(", ", numbers)); // Output: 100, 200, 300

            #endregion

            #region Q2: Write a c# Function that accept 4 parameters from user and return result of summation and subtracting of two numbers

            //int sum, mul;
            //SumMul(10, 20, out sum, out mul);
            //Console.WriteLine("Sum: " + sum); // 30
            //Console.WriteLine("Mul: " + mul); // 200

            #endregion

            #region Q3: Create a function named MinMaxArray, to return the minimum and maximum values stored in an array, using reference parameters

            //int[] arr = { 10, 20, 30, 40, 50 };
            //int min, max;
            //MinMaxArray(arr, out min, out max);
            //Console.WriteLine("Min: " + min); // 10
            //Console.WriteLine("Max: " + max); // 50

            #endregion
        }

        #region Q1 Methods
        //static void ModifyByValue(int[] arr)
        //{

        //    arr[0] = 10;

        //    arr = new int[] { 50, 60, 70 };
        //}

        //static void ModifyByReference(ref int[] arr)
        //{

        //    arr = new int[] { 100, 200, 300 };
        //}
        #endregion

        #region Q2 Methods
        //static void SumMul(int num1, int num2, out int sum, out int mul)
        //{

        //    sum = num1 + num2;
        //    mul = num1 * num2;

        //}
        #endregion

        #region Q3 Methods
        //static void MinMaxArray(int[] arr, out int min, out int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        else if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //}
        #endregion

    }

}