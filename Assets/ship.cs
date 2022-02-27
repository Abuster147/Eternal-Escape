using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship : MonoBehaviour
{
    public PlayerMovement movement;

   private void OnCollisionEnter(Collision collisionInfo)
    {
       if(collisionInfo.collider.tag== "Obstacle")
        {
            movement.enabled = false;
        }
    }
}
