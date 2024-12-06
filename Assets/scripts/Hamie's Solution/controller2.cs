using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller2 : MonoBehaviour
{
    //---------------------------------//
    private GameManager GM;
    private targets[] t;
    private int currentTargetIndex = 0;
    [SerializeField] private Camera playerCamera;
    [SerializeField] private LayerMask obstacleLayer;
    private void Start()
    //---------------------------------//
    {
        GM = FindObjectOfType<GameManager>();
        // Set GM to the instance of the game manager object
        t = FindObjectsOfType<targets>();
        // Set the array t to all targets within the scene,
        FaceNextVisibleTarget();
        // Face the "next" visible target first, to find the first one.
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Every time space is pressed, face the next visible target/
            FaceNextVisibleTarget();
        }
    }
    private void FaceNextVisibleTarget()
    {
        int targetCount = t.Length;
        // Create an integer called target count and set it to the length of the targets collected array.
        for (int i = 0; i < targetCount; i++)
        {
            currentTargetIndex = (currentTargetIndex + 1) % targetCount;
            // Set the current index to the Current Index + 1, as a percent of the target arrau.
            targets tar = t[currentTargetIndex];

            playerCamera.transform.LookAt(tar.transform);
            // Face the camera towards the target with this position within the array.
            return;

        }
    }
}