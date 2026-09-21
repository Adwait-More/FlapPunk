
using UnityEngine;

public class StaticInit : MonoBehaviour
{
  public static GameManager  gameManager;
  public static AudioManager  AudioManager;
  public static Vector3 screenLeftEdge;
  static public Vector3 screenRightEdge;
  static public Vector3 screenTopEdge;
  static public Vector3 screenBottomEdge;
  public Vector3 L_edgeSet;
  public Vector3 R_edgeSet;
  public Vector3 T_edgeSet;
  public Vector3 B_edgeSet;
  private void Awake()
  {
    AudioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
    gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    screenLeftEdge=Camera.main.ViewportToWorldPoint(L_edgeSet);
    screenRightEdge=Camera.main.ViewportToWorldPoint(R_edgeSet);
    screenTopEdge=Camera.main.ViewportToWorldPoint(T_edgeSet);
    screenBottomEdge=Camera.main.ViewportToWorldPoint(B_edgeSet);
    
  }
}
