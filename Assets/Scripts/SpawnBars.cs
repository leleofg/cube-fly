using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBars : MonoBehaviour
{
    [SerializeField] private GameObject bars;
    [SerializeField] private float height;
    [SerializeField] private float maxTime;
    
    private float timer = 0f;

    void Start()
    {
        GameObject newBars = Instantiate(bars);
        newBars.transform.position = transform.position + new Vector3(0, Random.Range(-height, +height), 0);
    }

    void Update()
    {
        if (timer > maxTime)
        {
            GameObject newBars = Instantiate(bars);
            newBars.transform.position = transform.position + new Vector3(0, Random.Range(-height, +height), 0);
            Destroy(newBars, 10f);
            timer = 0f;
        }

        timer += Time.deltaTime;
    }
}
