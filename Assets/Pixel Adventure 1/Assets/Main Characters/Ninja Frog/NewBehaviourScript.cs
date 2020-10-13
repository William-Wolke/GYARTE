using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float controllX = Input.GetAxisRaw("Horizontal");

        Vector3 movementX = Vector3.right * Time.deltaTime * speed * controllX;

        if (Mathf.Abs(transform.position.x) > 5)
        {
            transform.Translate(-movementX);
        }
    }
}
