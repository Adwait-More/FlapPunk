using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{
    public float startingSpeed = 0f;
    public float currentSpeed;
    public float decleration = 10f;
    bool hasTouched = false;
    bool goingUp;
    bool goingDown;
    bool IsFlappy = true;
    [SerializeField]private GameManager gameManager;
    [SerializeField]private StateMachine stateMachine;
    
    void Update()
    {
        if (IsFlappy)
        {
            if (stateMachine.currentState == GameState.GameOver)
            {
                return;
            }

            currentSpeed -= decleration * Time.deltaTime;
            transform.position += Vector3.up * currentSpeed * Time.deltaTime;

            if (Input.touchCount > 0)
            {

                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    if (hasTouched == false)
                    {
                        stateMachine.StartGame();
                        hasTouched = true;
                    }

                    Jump(); 

                }

            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (hasTouched == false)
                {
                    Time.timeScale = 1;
                    hasTouched = true;
                }

                Jump();
            }



            if (transform.position.y > 5f || transform.position.y < -5f)
            {
                gameManager.RestartLVl();
            }
            
        }
        else
        {
            
        }
    }
    
    public void Jump()
    {
        gameManager.IsGoingUp();
        currentSpeed = startingSpeed;

    }
    public void GoUp()
    {
        transform.position += Vector3.up * currentSpeed * Time.deltaTime;
        gameManager.IsGoingUp();}
    public void GoDown()
    {
    transform.position += Vector3.down * currentSpeed * Time.deltaTime;
    gameManager.IsGoingDown();
    }
}





