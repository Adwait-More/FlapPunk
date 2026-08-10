using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    
 
    
    

   public float startingSpeed = 0f;
   public float currentSpeed;
   public float decleration = 10f;
   int touchCount = 0;
    bool goingUp;
    bool goingDown;
    private GameManager gameManager;
  
 

    void Start()
    {
  
          
        
        
        gameManager = FindAnyObjectByType<GameManager>();
        
    
    }


    void Update()
    {
        currentSpeed -= decleration * Time.deltaTime;
        transform.position += Vector3.up * currentSpeed * Time.deltaTime;

        if (Input.touchCount > 0)
        {

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                if (touchCount == 0)
                {
                    Time.timeScale = 1;
                    touchCount++;
                }
                GoUp();

            }
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {


            Time.timeScale = 1;
            touchCount++;
            
            GoUp();
        }



        if(transform.position.y > 5f || transform.position.y < -5f)
    {
            gameManager.RestartLVl();
        }
    }
   public void GoUp()
    {
        gameManager.IsGoingUp();
        currentSpeed = startingSpeed;
       
    }

}



