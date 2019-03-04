using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    Rigidbody2D rb;
    SpriteRenderer sr;
    int health;
    bool bounce;
    public GameObject prefab;
    float time = 0.0f;
    public float interval = 0.35f;
    //public static bool dead;
    public static bool oneDead;
    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();
        health = 100;
        bounce = false;
        interval = 1;
        //dead = false;
        oneDead = false;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        sr.color = Color.white;
        if (time >= interval)
        {
            time = 0f;
            GameObject obj = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
        }
 
        if (health <= 0)
        {
            Destroy(gameObject);
            //dead = true;
            oneDead = true;
        }
        if (bounce == true)
        {
            rb.velocity = new Vector2(2f, 0f);
        }
        else if (bounce == false)
        {
            rb.velocity = new Vector2(-2f, 0f);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.name.Contains("LeftBound"))
        {
            bounce = true;
        }
        if (collision.name.Contains("RightBound"))
        {
            bounce = false;
        }
        if (collision.name.Contains("Laser"))
        {
            health = health - 40;
            sr.color = Color.yellow;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

    }
}
