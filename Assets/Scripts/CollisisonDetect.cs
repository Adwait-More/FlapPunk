using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollisisonDetect : MonoBehaviour
{
    public int Score = 0;
    public Animator MyAnim;


    private void OnTriggerEnter2D(Collider2D collision)


    {
        if(collision.gameObject.CompareTag("Pipe"))
        {
            FindObjectOfType<AudioManager>().PlayCollisionSound();
            var _Pipes = FindObjectsOfType<PipeMovement>();
            foreach(var pipe in _Pipes)
            {
                pipe.DisableMovement();
            }
            FindObjectOfType<GameManager>().RestartLVl();
            Debug.Log("Game Over");
            MyAnim.SetTrigger("Collided");




        }
        else if(collision.gameObject.CompareTag("ScoreCollider"))
        {
            Score++;
            FindObjectOfType<AudioManager>().PlayPointSound();
            Debug.Log("Score: " + Score);
           
            FindObjectOfType<UiManager>().UpdateScore();
        }
    }


}
