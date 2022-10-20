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
    public Vector2 size;
    Vector2 pos;
    Rectangle rec;
    public GameObject[] platformPrefab;

    void Start()
    {
        rec.rectanlgeBottomDown = new Vector2(-size.x, -size.y) + new Vector2(0, transform.position.y);
        rec.rectangleSize = new Vector2(size.x * 2, size.y * 2);
        Generate(20);
        rec.rectanlgeBottomDown = new Vector2(-size.x, -size.y) + new Vector2(0, transform.position.y + 10);
        Generate(20);
        rec.rectanlgeBottomDown = new Vector2(-size.x, -size.y) + new Vector2(0, transform.position.y + 10);
        Generate(20);
    }

    void Update()
    {
        rec.rectanlgeBottomDown = new Vector2(-size.x, -size.y) + new Vector2(0, transform.position.y + 10);
        if(pos.y + 10 <= transform.position.y + 20)
        {
            pos.y = transform.position.y + 20;
            Generate(20);
        }
        DebugRec(rec);
    }

    void Generate(int num)//rectangle is random location inside the coord and nm the number of GameObject to generate
    {
        for (int i = 0; i < num; i++)
        {
            float randomX = Random.Range(rec.rectanlgeBottomDown.x, rec.rectanlgeBottomDown.x + rec.rectangleSize.x);
            float randomY = Random.Range(rec.rectanlgeBottomDown.y, rec.rectanlgeBottomDown.y + rec.rectangleSize.y);
            GameObject platform = platformPrefab[RandomPlatform()];
            Instantiate(platform, new Vector3(randomX, randomY, 0f), platform.transform.rotation);
        }
    }

    void DebugRec(Rectangle rectangle)
    {
        Debug.DrawLine(rectangle.rectanlgeBottomDown, new Vector2(rectangle.rectanlgeBottomDown.x + rectangle.rectangleSize.x, rectangle.rectanlgeBottomDown.y),Color.green);
        Debug.DrawLine(rectangle.rectanlgeBottomDown, new Vector2(rectangle.rectanlgeBottomDown.x, rectangle.rectanlgeBottomDown.y + rectangle.rectangleSize.y), Color.green);
        Debug.DrawLine(new Vector2(rectangle.rectanlgeBottomDown.x + rectangle.rectangleSize.x, rectangle.rectanlgeBottomDown.y + rectangle.rectangleSize.y), new Vector2(rectangle.rectanlgeBottomDown.x + rectangle.rectangleSize.x, rectangle.rectanlgeBottomDown.y), Color.green);
        Debug.DrawLine(new Vector2(rectangle.rectanlgeBottomDown.x + rectangle.rectangleSize.x, rectangle.rectanlgeBottomDown.y + rectangle.rectangleSize.y), new Vector2(rectangle.rectanlgeBottomDown.x, rectangle.rectanlgeBottomDown.y + rectangle.rectangleSize.y), Color.green);
    }
    int RandomPlatform()
    {
        int[] rand = {0,0,0,0,0,0};
        return rand[Random.Range(0, rand.Length)];
    }
}
