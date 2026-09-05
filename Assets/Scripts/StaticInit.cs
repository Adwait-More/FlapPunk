
using UnityEngine;

public class StaticInit : MonoBehaviour
{
  public static GameManager  gameManager;
  public static AudioManager  AudioManager;
  public static Vector3 screenLeftEdge;
  static public Vector3 screenRightEdge;
  public Vector3 L_edgeSet;
  public Vector3 R_edgeSet;
  private void Awake()
  {
    AudioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    screenLeftEdge=Camera.main.ViewportToWorldPoint(L_edgeSet);
    screenRightEdge=Camera.main.ViewportToWorldPoint(R_edgeSet);
    
  }
}
