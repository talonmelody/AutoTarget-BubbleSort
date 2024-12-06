using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    private gameManager gm;
    public cubeBehaviour[] allTargets;
    private int index = 0;
    private Camera playerCam;

    private void Start()
    {
        gm         = FindObjectOfType<gameManager>();
        allTargets = FindObjectsOfType<cubeBehaviour>();
        //FaceNextVisibleTarget();
    }



    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //FaceNextVisibleTarget();
        }

    }






  /*  private void FaceNextVisibleTarget()
    {
        int targetCount = allTargets.Length;
        for (int i = 0; i < targetCount; i++)
        {
            index = (index + 1) % targetCount;
            allTargets tar = allTargets[index];



        }
    
    
    }
  */






}
