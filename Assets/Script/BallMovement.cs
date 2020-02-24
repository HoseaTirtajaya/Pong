using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
   
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        int rand = Random.Range(0, 2);
        rb = GetComponent<Rigidbody2D>();

        if(rand == 0)
        {
            rb.velocity = new Vector2(-18f, 0f);
        }
        else if(rand == 1)
        {
            rb.velocity = new Vector2(18f, 0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(this.transform.position.x) >= 14)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            int rand = Random.Range(0, 2);
            if (rand == 0)
            {
                rb.velocity = new Vector2(-18f, 0f);
            }
            else if (rand == 1)
            {
                rb.velocity = new Vector2(18f, 0f);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        float dist = this.transform.position.y - GameObject.Find("Player1").transform.position.y;
        float dist2 = this.transform.position.y - GameObject.Find("Player2").transform.position.y;

        if(collision.gameObject.name == "Player1")
        {
            rb.velocity = new Vector2(20f, dist * 2f);
        }
        if(collision.gameObject.name == "Player2")
        {
            rb.velocity = new Vector2(-20f, dist2 * 2f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Left")
        {
            //Debug.Log("Nambah Score player 2");
            Score.Player2Score++;
        }
        if (collision.gameObject.name == "Right")
        {
            //Debug.Log("Nambah Score player 1");
            Score.Player1Score++;
        }
    }

    public void ResetPosition()
    {
        
        if (Mathf.Abs(this.transform.position.x) >= 14)
        {
            this.transform.position = new Vector3(0f, 0f, 0f);
            int rand = Random.Range(0, 2);
            if (rand == 0)
            {
                rb.velocity = new Vector2(-18f, 0f);
            }
            else if (rand == 1)
            {
                rb.velocity = new Vector2(18f, 0f);
            }
        }
    }


}
