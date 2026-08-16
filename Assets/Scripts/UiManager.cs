using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Jobs;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]
     TextMeshProUGUI scoreText;
    int score;

    private void Start()
    {
        score = FindAnyObjectByType<CollisisonDetect>().score;
        score++;
    }

    public void UpdateScore()
    {
       scoreText.text="Score:"+score.ToString();
        score++;
       
    }
    
}
