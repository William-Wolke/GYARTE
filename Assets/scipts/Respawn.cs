using System.Timers;
using System;
using System.Threading;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
/*using System.Xml;
using System.Xml.Serialization;*/

[RequireComponent(typeof(Collider2D))]
public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform teleport;
    public static int timesLost;


    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            other.transform.position = teleport.position;
            timesLost++;
        }
    }
}