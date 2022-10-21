using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLocationOnPlatform : MonoBehaviour
{
    public int chance;
    public GameObject spring;
    private void Awake()
    {
        int i = Random.Range(0, chance);
        if (i == 0)
        {
            Vector2 pos = new Vector2(Random.Range(transform.position.x - transform.localScale.x / 2f + spring.transform.localScale.x / 2f, transform.position.x + transform.localScale.x / 2f - spring.transform.localScale.x / 2f), transform.position.y + transform.localScale.y / 2f + spring.transform.localScale.y / 2f);
            Instantiate(spring, pos, spring.transform.rotation);
        }
    }
}
