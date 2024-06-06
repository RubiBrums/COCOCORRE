using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingTilemap : MonoBehaviour
{
    public float scrollSpeed = 5f;

    void Update()
    {
        float moveAmount = scrollSpeed * Time.deltaTime;

        foreach (Transform child in transform)
        {
            child.Translate(Vector2.left * moveAmount);
        }
    }
}