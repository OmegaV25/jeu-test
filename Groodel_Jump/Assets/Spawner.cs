using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public struct Rectangle
{
    public Vector2 rectanlgeBottomDown;
    public Vector2 rectangleSize;
}

public class Spawner : MonoBehaviour
{
    public Transform pos;
    public Color color;
    Rectangle rec;
    public Vector2 originalPos;
    Vector2 nextPos;
    public GameObject platformPrefab;
    public bool test;


    // Start is called before the first frame update
    void Start()
    {
        nextPos = originalPos;
        //InvokeRepeating("Test",1f,0.2f);
        color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {

        if(test)
        {
            test = false;
            rec.rectanlgeBottomDown = new Vector2(-5,-5) + new Vector2(pos.position.x, pos.position.y);
            rec.rectangleSize = Vector2.one * 10;
            Generate(rec, 5);
        }
    }

    void Generate(Rectangle rectangle,int num)//rectangle is random location inside the coord and nm the number of GameObject to generate
    {
        for (int i = 0; i < num; i++)
        {
            float randomX = Random.Range(rectangle.rectanlgeBottomDown.x, rectangle.rectanlgeBottomDown.x + rectangle.rectangleSize.x);
            float randomY = Random.Range(rectangle.rectanlgeBottomDown.y, rectangle.rectanlgeBottomDown.y + rectangle.rectangleSize.y);

            Instantiate(platformPrefab, new Vector3(randomX, randomY, 0f), platformPrefab.transform.rotation);
        }
    }

    void Test()
    {
        test = true;
    }   
}
