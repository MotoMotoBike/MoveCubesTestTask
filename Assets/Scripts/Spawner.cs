using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using TextMesh_Pro;
using Unity.VisualScripting;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public GameObject prefab;
    public float delay = 5f;

    public CubeStats stats = new CubeStats(0.1f, 10);
    
    private void Awake()
    {
        StartCoroutine(SpawnObjects());
    }
    
    IEnumerator SpawnObjects()
    {
        while (true)
        {
            GameObject cube = Instantiate(prefab);
            cube.GetComponent<CubeMovementScript>().stats = new CubeStats(stats);
            
            yield return new WaitForSeconds(delay);
        }
    }
}
