using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{
    public float movementSpeed = 10f;
    float movement = 0f;
    float border;

    Rigidbody2D rb;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        border = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, 0)).x;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x - GetComponent<BoxCollider2D>().size.x/2f >= border)
        {
            transform.position = new Vector3(-border, transform.position.y, transform.position.z);
        }
        else if (transform.position.x + GetComponent<BoxCollider2D>().size.x / 2f <= -border)
        {
            transform.position = new Vector3(border, transform.position.y, transform.position.z);
        }
        movement = Input.GetAxis("Horizontal") * movementSpeed;
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector2(movement, rb.velocity.y);
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Animator>().SetBool("IsJumping",true);
    }

    private void OnCollisionExit(Collision collision)
    {
        GetComponent<Animator>().SetBool("IsJumping", false);
    }
}
