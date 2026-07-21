using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]  TextMeshProUGUI ScoreText;
    int score;



    public void UpdateScore()
    {
       ScoreText.text="Score:"+FindAnyObjectByType<CollisisonDetect>().Score.ToString();
        score++;
       
    }
    
}
