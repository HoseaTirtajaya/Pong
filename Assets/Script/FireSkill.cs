using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireSkill : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player1")
        {
            //Debug.Log("Player 1 nyentuh fire");
            Score.Player2Score += 1000;
        }
        else if(collision.gameObject.name == "Player2")
        {
            Score.Player1Score += 1000;
            //Debug.Log("Player 2 nyentuh fire");
        }
    }
}
