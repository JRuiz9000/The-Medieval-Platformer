using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class KnightPlayerScoreController : MonoBehaviour
{
     public Text livesSetting; //Text Object that keeps score

     public Transform mainCamera; //Transform object to set camera

     public Transform knight; //Transform object that keeps knight position 

    // Start is called before the first frame update
    void Start()
    {
       livesSetting.text = "Lives: " + PlayerLivesCounter.numOfLives.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        mainCamera.position = new Vector3(mainCamera.position.x, mainCamera.position.y, knight.position.z - 3); //Back View of Camera Position
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "bottomlesspit" || collision.gameObject.tag == "enemy" || collision.gameObject.tag == "barrel")
        {
            PlayerLivesCounter.numOfLives--;
            livesSetting.text = "Lives: " + PlayerLivesCounter.numOfLives.ToString();

            if (PlayerLivesCounter.numOfLives <= 0)
            {
                Debug.Log("Sorry, It's Game Over!");
                SceneManager.LoadScene("LoseScene");
            }
        }
    }
}
