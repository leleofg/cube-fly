using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int speed;
    public GameObject GameOver;
    public GameObject RestartBtn;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * speed * Time.fixedDeltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        GameOver.SetActive(true);
        RestartBtn.SetActive(true);
        Time.timeScale = 0;
    }
}
