using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    private float speed = 2;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
