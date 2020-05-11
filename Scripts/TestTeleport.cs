using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestTeleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject KnightPlayer;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
       KnightPlayer.transform.position = teleportTarget.transform.position;  
    }
}
