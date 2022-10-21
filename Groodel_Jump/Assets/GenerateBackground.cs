using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateBackground : MonoBehaviour
{
    public Transform player;

    private void Update()
    {
        if(player.transform.position.y >= transform.position.y)
        {
            Debug.Log("NIQUE TA MERE");
            Vector3 newbg = new Vector3(transform.position.x, transform.position.y + 16.2f * 2f, transform.position.z);
            Instantiate(gameObject, newbg,transform.rotation);
            Destroy(gameObject.GetComponent<GenerateBackground>());
        }

        Debug.Log(transform.position.y);
    }
}
