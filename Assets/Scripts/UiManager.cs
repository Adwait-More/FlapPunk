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
    [SerializeField] CollisisonDetect scoreCollisison;
    [SerializeField] TextMeshProUGUI scoreText;
    
    

    

    public void UpdateScore()
    {
        scoreText.text = "SCORE:" + scoreCollisison.score.ToString();
    }
    
}
