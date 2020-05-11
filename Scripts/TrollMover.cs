using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TrollMover : MonoBehaviour
{
    public AudioSource Roar;
    public GameObject knight;
    public Transform[] target;
    public float moveTrollSpeed;
    private int current;
    
    // Start is called before the first frame update
    void Start()
    {
       Roar.Play(); 
    }

    // Update is called once per frame
    void Update()
    {
      transform.LookAt(knight.transform);

       if (transform.position != target[current].position)
      {
        Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, moveTrollSpeed * Time.deltaTime);
        GetComponent<Rigidbody>().MovePosition(pos);
        
      }
      else current = (current + 1) % target.Length;

      if (Input.GetKeyDown(KeyCode.W) || (Input.GetKeyDown(KeyCode.S))) 
       {
          Roar.Play();
       } 
    }
}
