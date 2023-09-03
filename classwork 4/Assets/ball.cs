using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ball : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 13f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2 (0,-6);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = Vector2.ClampMagnitude(rb.velocity, speed);
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if (other.gameObject.name == "reset")
        {
            SceneManager.LoadScene(0);
        }
    }
}
