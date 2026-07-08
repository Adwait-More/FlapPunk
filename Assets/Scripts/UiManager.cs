using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField]  TextMeshProUGUI ScoreText;



    public void UpdateScore()
    {
       ScoreText.text="Score:"+FindObjectOfType<CollisisonDetect>().Score.ToString();
    }
}
