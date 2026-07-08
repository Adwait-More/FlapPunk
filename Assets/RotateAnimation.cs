using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.Animations;

public class RotateAnimation : MonoBehaviour
{
    [SerializeField] float RotationMultiplier = 50f;
  
    void Update()
    {
      
        float RotationSpeed = FindObjectOfType<PlayerMovement>().CurrentSpeed * RotationMultiplier;
    transform.Rotate(Vector3.forward, RotationSpeed * Time.deltaTime);
    }
}
