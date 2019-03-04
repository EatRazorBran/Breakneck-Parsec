using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject prefab;
    bool move;
    //float time = 0.0f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        move = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Enemy2.dead == true && EnemyScript.oneDead == true)
        {
            move = true;
        }
        //time = Time.deltaTime;
        rb.angularVelocity += 0;
        rb.velocity = new Vector2(0f,0f);

        if (Input.GetKey(KeyCode.D) && move == false)
        {
            rb.AddForce(transform.right * 75);
        }
        if (Input.GetKey(KeyCode.A) && move == false)
        {
            rb.AddForce(transform.right * -75);
        }

        if (Input.GetKey(KeyCode.W) && move == true)
        {
            rb.AddForce(transform.up * 50);
        }
        if (Input.GetKey(KeyCode.S)&&move==true)
        {
            rb.AddForce(transform.up * -50);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            
            GameObject obj = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
            

        }
        if (Input.GetKeyDown(KeyCode.D)&&move==true)
        {
            rb.angularVelocity += -230;
        }
        if (Input.GetKeyUp(KeyCode.D) && move == true)
        {
            rb.angularVelocity = 0;
        }
        if (Input.GetKeyDown(KeyCode.A) && move == true)
        {
            rb.angularVelocity += 230;
        }
        if (Input.GetKeyUp(KeyCode.A) && move == true)
        {
            rb.angularVelocity = 0;
        }
    }
}
