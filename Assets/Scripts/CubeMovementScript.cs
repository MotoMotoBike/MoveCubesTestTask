using System.Collections;
using System.Collections.Generic;
using TextMesh_Pro;
using UnityEngine;

public class CubeMovementScript : MonoBehaviour
{
    const float gravity = 20f;
    
    private Vector3 spawnPos;
    
    public CubeStats stats = new CubeStats(0.1f, 10);
    
    private CharacterController controller;
    
    void Awake()
    {
        controller = GetComponent<CharacterController>();
        spawnPos = this.transform.position;
    }

    void FixedUpdate()
    {
        Vector3 direction = (transform.forward * stats.speed);
        
        if (!controller.isGrounded)
        {
            direction += (transform.up * -gravity);
        }

        if (Vector3.Distance(spawnPos,transform.position) > stats.destroyDist)
        {
            Destroy(this.gameObject);
        }
        controller.Move(direction);
    }
}
