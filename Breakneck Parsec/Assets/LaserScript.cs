using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserScript : MonoBehaviour
{
    Rigidbody2D rb;
    Rigidbody2D br;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.Find("Player");
        br = player.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // rb.velocity = new Vector2(br.velocity.x, 2f);
        rb.AddForce(transform.up * 20);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name.Contains("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
