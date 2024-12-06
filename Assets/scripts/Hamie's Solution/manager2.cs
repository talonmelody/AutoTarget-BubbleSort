using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
  // These are Hamie's Solutions, being used as reference
    
    private targets[] targets;
    private int[] hpValues;
    void Start()
    {
        targets = FindObjectsOfType<targets>();
        // Fill the targets array with every object in the scene with the targets script attached.
        hpValues = new int[targets.Length];
        // Set the hpValues variable to the length of the targets array, so we know how many there were
        for (int i = 0; i < targets.Length; i++)
        {
            // For as many targets, 
            hpValues[i] = targets[i].GetHealthPoints();
        }
        BubbleSort(hpValues);
        for (int i = 0; i < hpValues.Length; i++)
        {
            Debug.Log("Target " + (i + 1) + "HP: " + hpValues[i]);
        }
    }
    void BubbleSort(int[] array) // Typical bubble sort functuib
    {
        int n = array.Length;           // Set n to the length of the inputted array
        for (int i = 0; i < n - 1; i++) // Repeat until i = the length of the array - 1
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[i] < array[j])
                {
                    int temp = array[j];
                    array[j + 1] = temp;
                }

            }
        }
    }
    
    public int[] GetSortedHpValues()  // Returns the sorted HP values when called.
    { return hpValues; }
}