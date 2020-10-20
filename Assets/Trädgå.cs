using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trädgå : MonoBehaviour
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

        Vector3 movementX = Vector3.left * Time.deltaTime * speed * controllX;
        transform.Translate(-movementX);

        float controllY = Input.GetAxisRaw("Vertical");

        Vector3 movementY = Vector3.up * Time.deltaTime * speed * controllY;
        transform.Translate(movementY);
        
        
    }
}
