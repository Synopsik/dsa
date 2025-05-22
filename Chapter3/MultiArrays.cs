namespace Chapter3;

public class MultiArrays
{
    // ------------------------------------------------------------------------------------------------ //
    //                                          2D Arrays                                               //
    // ------------------------------------------------------------------------------------------------ //
    public static void TwoD_Demo()
    {
        // Create a two dimensional array
        int[,] numbers = new int[10, 5];

        // Find the end index for each dimension
        var dimOneEnd = numbers.GetLength(0) - 1;
        var dimTwoEnd = numbers.GetLength(1) - 1;
        
        numbers[dimOneEnd, dimTwoEnd] = 17;
        
        // We can also combine a declaration with an initialization
        var numbers2 = new int[,]
        {
            { 9, 5, -9 },
            { -11, 4, 0 },
            { 6, 115, 3 },
            { -12, -9, 71 },
            { 1, -6, -1 }
        };

        // We use the same method to access elements from the array

        int element = numbers2[2, 1];
        numbers2[1, 0] = 11;

    }
    
    // ------------------------------------------------------------------------------------------------ //
    //                                          3D Arrays                                               //
    // ------------------------------------------------------------------------------------------------ //

    public static void threeD_Demo()
    {
        
    }
}