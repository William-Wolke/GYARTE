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
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("trigger is running");
        if (other.CompareTag("Player"))
        {
            Debug.Log("player hit trigger");
            other.transform.position = teleport.position;
        }
    }
}