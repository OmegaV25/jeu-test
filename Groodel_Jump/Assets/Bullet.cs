using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Bullet : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Rigidbody2D>().velocity = new Vector3(0,-5,0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("LoseMenu");
        }
    }
}
