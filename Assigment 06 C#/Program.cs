namespace Assignment_06_Updated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1: Difference Between Passing by Value and Reference with Example

            /*
            -- Passing by value: The method receives a copy of the reference.
               Changes to object properties inside the method affect the original object as they share the same memory location,
               but reassigning the reference doesn't affect the original.

            -- Passing by reference: The method receives the actual reference.
               Reassigning the reference or modifying the object will reflect outside the method.
            */

            // Example
            //int[] numbers = { 5, 10, 15 };

            //// Passing by value
            //ModifyByValue(numbers);
            //Console.WriteLine("After ModifyByValue: " + string.Join(", ", numbers)); // Output: 20, 10, 15

            //// Passing by reference
            //ModifyByReference(ref numbers);
            //Console.WriteLine("After ModifyByReference: " + string.Join(", ", numbers)); // Output: 100, 200, 300

            #endregion

            #region Q2: Function to Return Summation and Multiplication of Two Numbers

            //int sumResult, mulResult;
            //CalculateSumAndProduct(12, 8, out sumResult, out mulResult);
            //Console.WriteLine("Sum: " + sumResult); // Output: 20
            //Console.WriteLine("Product: " + mulResult); // Output: 96

            #endregion

            #region Q3: Min and Max Values in an Array Using Reference Parameters

            //int[] numbersArray = { 25, 45, 10, 80, 15 };
            //int minimum, maximum;
            //FindMinMax(numbersArray, out minimum, out maximum);
            //Console.WriteLine("Minimum: " + minimum); // Output: 10
            //Console.WriteLine("Maximum: " + maximum); // Output: 80

            #endregion
        }

        #region Q1 Methods
        //static void ModifyByValue(int[] arr)
        //{
        //    arr[0] = 20; // Changes the content as the reference points to the same memory location
        //    arr = new int[] { 50, 60, 70 }; // This reassigning won't affect the original reference
        //}

        //static void ModifyByReference(ref int[] arr)
        //{
        //    arr = new int[] { 100, 200, 300 }; // Reassigning affects the original reference
        //}
        #endregion

        #region Q2 Methods
        //static void CalculateSumAndProduct(int num1, int num2, out int sum, out int product)
        //{
        //    sum = num1 + num2;
        //    product = num1 * num2;
        //}
        #endregion

        #region Q3 Methods
        //static void FindMinMax(int[] arr, out int min, out int max)
        //{
        //    min = arr[0];
        //    max = arr[0];
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        if (arr[i] < min)
        //        {
        //            min = arr[i];
        //        }
        //        if (arr[i] > max)
        //        {
        //            max = arr[i];
        //        }
        //    }
        //}
        #endregion
    }
}
