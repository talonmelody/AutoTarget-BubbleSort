using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class targets : MonoBehaviour
{
    // These are Hamie's Solutions, being used as reference
    [SerializeField] private int healthPoints; //private but still visible in spectre

    public int GetHealthPoints()
    {
        return healthPoints;
    }
}