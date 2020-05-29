using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        GameController.Instance.AddPoints();
    }
}
