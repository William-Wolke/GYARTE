using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trädgå : MonoBehaviour
{
    public float speed = 7;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float controllX = Input.GetAxisRaw("Horizontal");

        Vector3 movementX = Vector2.left * Time.deltaTime * speed * controllX;
        transform.Translate(-movementX);

        animator.SetFloat("Speed", Mathf.Abs(controllX));

        float controllY = Input.GetAxisRaw("Vertical");

        Vector3 movementY = Vector2.up * Time.deltaTime * speed * controllY;
        
        
        if (controllY <= 0){
           movementY = Vector2.up * Time.deltaTime * speed * controllY * 0;
           //animator.SetBool("IsJumping", true);
        }

        transform.Translate(movementY);
        
    }
}
