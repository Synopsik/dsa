namespace Chapter3;

public class Arrays
{
    // ------------------------------------------------------------------------------------------------ //
    //                                          1D Arrays                                               //
    // ------------------------------------------------------------------------------------------------ //
    /* Syntax:
     *          type[] name;
     *
     * 
     */
    public static void ArraysDemo()
    {
        
        float[] temps; // Declare array

        var numbers = new int[5];

        numbers[0] = 9;
        numbers[1] = 19;
        numbers[2] = 29;
        numbers[3] = 39;
        numbers[4] = 49;

        // We can also init on a single line
        var numbers2 = new int[] { 9, -11, 6, -12, 1 };
        // Or
        int[] numbers3 = { 9, -11, 6, -12, 1 };
        // Or
        int[] numbers4 = [ 9, -11, 6, -12, 1 ];
        // Since we know the length of our array, we can specify the middle index
        var middle = numbers[2];

        var last1 = numbers[numbers.Length - 1];
        // this can be simplified with an index operator
        var last2 = numbers[^1];
        
        // Rank returns the number of dimensions for an array
        int rank = numbers.Rank;
        
        // We can use the Exists method to check if there are any elements that match a given predicate
        bool anyPositive = Array.Exists(numbers, e => e > 0);
        
        // We can use TrueForAll to check that all elements match a given predicate
        bool noZeros = Array.TrueForAll(numbers, e => e != 0);
        
        // We can use Find to return the first element that matches a given predicate
        // Good for an extra layer of error handling,
        // ex. If a negative number is caught, what number?
        int firstNegative = Array.Find(numbers, e => e < 0);

        // We can use FindAll to return all results that match a given predicate
        int[] negatives = Array.FindAll(numbers, e => e < 0);
        
        // We can use IndexOf if you just want to check whether an array contains a specific element,
        //  without predicate conditions, returns -1 if not found
        int index = Array.IndexOf(numbers, -12);
        
        // We can use ForEach if we want to perform a map operation on an array
        Array.ForEach(numbers, e => Console.WriteLine(Math.Abs(e)));

        // As it's name suggests, Reverse is a static method used to reverse an array
        Array.Reverse(numbers, 0, 3);
        
        // Sort an array from the smallest to the largest
        Array.Sort(numbers);
        
        // We can Fill an array with a specified value
        Array.Fill(numbers, 3);
        
        // We can Clear an array to zero it out
        Array.Clear(numbers);
        
        // We can Copy an array 
        var subarray = new int[3];
        Array.Copy(numbers, 0, subarray, 0, 3);
        

    }
    
}