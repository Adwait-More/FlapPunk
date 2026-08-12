using UnityEngine;

public class StateMachine : MonoBehaviour
{
    public GameState currentState;

    void Start()
    {
        currentState = GameState.GetReady;
        Time.timeScale = 0f;
    }

    void StartGame()
    {
        Time.timeScale = 1f;
        currentState=GameState.Playing;
    }

    public void EndGame()
    {
         currentState=GameState.GameOver;
    }
}
