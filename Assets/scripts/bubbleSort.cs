using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleSort : MonoBehaviour
{

    // Create an array of integers with these unnordered numbers.
    int[] numberArray = { 6, 3, 6, 12, 5, 3, 6, 2, 4, };                


    private void Start()
    {
        // Output "Original Array:" combined with the array converted to a string.
        Debug.Log("Original Array: " + ArrayToString(numberArray));

        // Call the bubbleSortArray method with the array as an input. 
        BubbleSortArray(numberArray);

        // Output "Sorted Array: " joined with the sorted array converted to a string.
        Debug.Log("Sorted Array: " + ArrayToString(numberArray));

    }

    string ArrayToString(int [] array)
    {
        // Return the array as a string, seperated by commas.
        return string.Join(",", array); 
    }


    void BubbleSortArray(int [] array)
    { 

        int n = array.Length;

        for (int i = 0; i < n - 1; i++)

        {
            for (int j = 0; j < n - i - 1; j++)
            {
              
                if (array[j] > array[j + 1])
             
                {
                    int temp = array[j];

                    array[j] = array[j + 1]; 
                    
                    array[j + 1] = temp;    
              
                }

            }

        }


    }

}
