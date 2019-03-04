using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossLaserScript : MonoBehaviour
{
    Rigidbody2D rb;
    public static int vx;
    public static int vy;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        vx = Random.Range(-10, 10);
        vy = Random.Range(-10, 10);
    }

    // Update is called once per frame
    void Update()
    {
        //rb.AddForce(transform.up * vy);
        //rb.AddForce(transform.right * vx);
        //rb.velocity = new Vector2(vx, vy);
        rb.AddForce(transform.up * 10);
    }
}
