using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{
    public PlayerScript playerScript;
    public Score score;
    public GameController gameController;
    public AudioSource audiosource;
    public AudioSource audiosource1;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Collectable")
        {
            audiosource.Play();
            score.AddScore(1);
            Destroy(other.gameObject);
        }

    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Obsticals")
        {
            audiosource1.Play();
            gameController.GameOver();
            playerScript.enabled = false;
        }
        if (other.gameObject.tag =="endcube")
        {
            gameController.GameOver1();
            playerScript.enabled = false;
        }

    }
}
