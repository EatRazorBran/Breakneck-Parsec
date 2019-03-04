using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossScript : MonoBehaviour
{
    Rigidbody2D rb;
    Rigidbody2D br;
    public GameObject prefab;
    GameObject laser;
    public static float interval = 0.15f;
    float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        laser = GameObject.Find("BossLaser");
        br = laser.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        if (Enemy2.dead == true && EnemyScript.oneDead == true)
        {
            rb.velocity = new Vector2(1f, 0f);
            if (rb.position.x >= 0)
            {
                rb.velocity = new Vector2(0f, 0f);
                if (time >= interval)
                {
                    GameObject obj = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
                    time = 0f;
                    
                }
                rb.rotation = rb.rotation + 3;
            }
        }
    }
}
