
using UnityEngine;

public class StaticInit : MonoBehaviour
{
  [SerializeField]
   static public GameManager  gameManager;
   static public AudioManager  AudioManager;
  static public  Vector3 screenLeftEdge;
  static public Vector3 screenRightEdge;
  static public Vector3 screenTopEdge;
  static public Vector3 screenBottomEdge;
  public Vector3 L_edgeSet;
  public Vector3 R_edgeSet;
  public Vector3 T_edgeSet;
  public Vector3 B_edgeSet;
  private void Awake()
  {
      gameManager=GameObject.Find("GameManager").GetComponent<GameManager>();
      AudioManager = GameObject.Find("AudioManager").GetComponent<AudioManager>();
      screenLeftEdge=Camera.main.ViewportToWorldPoint(L_edgeSet);
      screenRightEdge=Camera.main.ViewportToWorldPoint(R_edgeSet);
      screenTopEdge=Camera.main.ViewportToWorldPoint(T_edgeSet);
      screenBottomEdge=Camera.main.ViewportToWorldPoint(B_edgeSet);
    
  }
}
