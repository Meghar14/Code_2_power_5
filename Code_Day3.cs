// cerner_2^5_2020
// C# program sort an array in  
using System; 
class GFG { 
    // Main Method 
    public static void Main() 
    { 
  
        // declaring and initializing the array 
        int[] arr = new int[] {1, 9, 6, 7, 5, 9}; 
  
        // Sort the arr from last to first. 
        // compare every element to each other 
        Array.Sort<int>(arr, new Comparison<int>( 
                  (i1, i2) => i2.CompareTo(i1))); 
  
        // print all element of array 
        foreach(int value in arr) 
        { 
            Console.Write(value + " "); 
        } 
    } 
} 