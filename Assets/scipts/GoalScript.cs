using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D))]
public class GoalScript : MonoBehaviour
{
    public static bool finished;
    //public string boolValue {get; set;}
    // Start is called before the first frame update
    void Start()
    {
        finished = false;
    }

    // Update is called once per frame
    public bool OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            finished = true;
        }
        return finished;
    }
}
