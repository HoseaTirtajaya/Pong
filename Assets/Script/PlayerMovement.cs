using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    //public CharacterController controller;
    private Rigidbody2D rb;
    private ContactPoint2D lastContactPoint;
    private Vector2 trajectoryOrigin;

    //float upMove = 0f;
    //float downMove = 0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trajectoryOrigin = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Debug.Log("atas");
            transform.position += Vector3.up * moveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //Debug.Log("Bawah");
            transform.position += Vector3.down * moveSpeed * Time.deltaTime;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DragonBall")
        {
            //Debug.Log("Nyentuh mamank");
            lastContactPoint = collision.GetContact(0);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        trajectoryOrigin = transform.position;  
    }

    public ContactPoint2D LastContactPoint()
    {
        return lastContactPoint;
    }

    public Vector2 TrajectoryOrigin()
    {
        return trajectoryOrigin;
    }

}
