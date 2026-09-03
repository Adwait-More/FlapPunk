
using UnityEngine;

public class StaticInit : MonoBehaviour
{
  static public Vector3 screenLeftEdge;
  static public Vector3 screenRightEdge;
  public Vector3 L_edgeSet;
  public Vector3 R_edgeSet;
  private void Awake()
  {
    screenLeftEdge=Camera.main.ViewportToWorldPoint(L_edgeSet);
    screenRightEdge=Camera.main.ViewportToWorldPoint(R_edgeSet);
    
  }
}
