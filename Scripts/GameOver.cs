using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    [SerializeField] private GameObject gameOver;
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject sad;


    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(player);
            sad.SetActive(true);
            gameOver.SetActive(true);
            
           // Debug.Log("DEAD");
        }
    }
}
