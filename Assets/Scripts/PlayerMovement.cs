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
    public bool goingUp;
    public bool goingDown;
    [SerializeField] bool IsFlappy = true;
    [SerializeField]private GameManager gameManager;
    [SerializeField]private StateMachine stateMachine;

    void Start()
    {
        stateMachine.StartGame();
    }
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
            Go();
        }
    }
    
    public void Jump()
    {
        gameManager.IsGoingUp();
        currentSpeed = startingSpeed;

    }
    public void Go()
    {
        transform.position += Vector3.up * currentSpeed * Time.deltaTime;
    }
    

    public void GO_UP()
    {
        currentSpeed = 5;

    }

    public void Set0()
    {
        currentSpeed = 0;
    }

    public void GO_DOWN()
    {
        currentSpeed = -5;
    }
}





