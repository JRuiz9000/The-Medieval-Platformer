using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetLives : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerLivesCounter.numOfLives = 3; //Restarts Life Count To 3   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

