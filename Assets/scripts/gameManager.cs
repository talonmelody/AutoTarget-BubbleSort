using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject[] allTargets;
    public int[] hpValues;
    public List<int> hpList;
    public int[] foundHPs;
    public int index = 0;

    public void Start()
    {
        // Create an array of all objects with the cubeBehaviour script attached. 
        allTargets = GameObject.FindGameObjectsWithTag("Target");
        GetHPValues(allTargets);
    }


    void BubbleSortArray(int[] array)
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

    void GetHPValues(GameObject[] array)
    {
       foreach (GameObject target in array)
        {
            hpList.Add(target.GetComponent<cubeBehaviour>().cubeHP);
        }
        Debug.Log(List2String(hpList));
        foundHPs = hpList.ToArray();
        BubbleSortArray (foundHPs);
        Debug.Log(Array2String(foundHPs));
    }


    private void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (index <= 0 && index != foundHPs.Length)
            {
                index++;
                Debug.Log(index);
            }  
        }
        else
        {
            index = 0;
        }
    }


    string List2String(List<int> list)
    {
        return string.Join(", ", list);
    }

    string Array2String(int[] array)
    {
        return string.Join(',', array);
    }





}



