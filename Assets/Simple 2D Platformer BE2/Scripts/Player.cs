using UnityEngine;

public class Player : MonoBehaviour
{
    float speed = 5f;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        float getHorizontalInput = Input.GetAxis("Horizontal");
        rb.linearVelocityX = getHorizontalInput * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(transform.up * 10f,ForceMode2D.Impulse);
        }

    }
}
