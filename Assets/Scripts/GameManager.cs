using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] AudioManager audioManager;
    [SerializeField] AnimationManager animationManager;
    [SerializeField]  PipeSpawnner spawnner;
    [SerializeField] UiManager uiManager;
    [SerializeField] Background background;
    private void Start()
    {
        Application.targetFrameRate = 120;
}

public void RestartLVl()
    {
        Invoke("InvRestartLvl", 0.5f);
    }
    public void NextLevel_delay()
    {
        Invoke("NextLevel", 0.5f);
    }
    public void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Next Level");
    }
    public void InvRestartLvl()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Next Level");
    }
    public void PreviousLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        Debug.Log("Previous Level");
    }

    public void GameOver()
    {
        animationManager.PlayCollisionAnimation();
        if (spawnner != null)
        {
            spawnner.DisablePipeMovement();
        }
        background.enabled = false;
        audioManager.PlayCollisionSound();
        
        RestartLVl();
    }
    public void GainPoint()
    {
        audioManager.PlayPointSound();
        uiManager.UpdateScore();
    }

    public void IsGoingUp()
    {
        AudioManager audioManager = FindAnyObjectByType<AudioManager>();
        audioManager.PlayJumpSound();
        animationManager.PlayPlayerAnimation();
    }
    public void IsGoingDown(){
}
}
