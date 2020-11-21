using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform teleport;

    void Start()
    {
        // Vector2 baguette = 
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleport.position;
            timesLost += 1;
        }
    }
}