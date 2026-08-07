using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisisonDetect : MonoBehaviour
{
    bool HasColided=false;
    public int Score = 0;
    public Animator MyAnim;
    private GameManager gameManager;
    private UiManager uiManager;
    private AudioManager audioManager;
    private void Start()
    {
     
        gameManager = FindObjectOfType<GameManager>();
        uiManager = FindObjectOfType<UiManager>();
        audioManager = FindObjectOfType<AudioManager>();
    }


    private void OnTriggerEnter2D(Collider2D collision)


    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            audioManager.PlayCollisionSound();
            gameManager.RestartLVl();
            gameManager.GameOver();
            Debug.Log("Game Over");
            MyAnim.SetTrigger("Collided");
            HasColided = true;



        }
        else if(collision.gameObject.CompareTag("ScoreCollider"))
        {
            Score++;
            gameManager.GainPoint();
            Debug.Log("Score: " + Score);
            
        }
    }


}
