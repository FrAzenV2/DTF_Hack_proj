using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movment_test : MonoBehaviour
{
    public GameObject bullet;

    private Rigidbody2D rb;

    public float speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        rb.position = (rb.position + Vector2.right * moveX * speed * Time.deltaTime);
        rb.position = (rb.position + Vector2.up * moveY * speed * Time.deltaTime);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            shoot();
        }
    }

    
}
