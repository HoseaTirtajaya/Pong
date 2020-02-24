using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnlargeSkill : MonoBehaviour
{
    public float Timer;

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
        if(collision.gameObject.name == "Player1")
        {
            Timer += Time.deltaTime;
            Debug.Log(Timer);
            if(Timer <= 10.0f)
            {
                Debug.Log("Enlarge nyentuh player 1");
            }
            
        }
        else if(collision.gameObject.name == "Player2")
        {
            Timer += Time.deltaTime;
            Debug.Log(Timer);
            if (Timer <= 10.0f)
            {
                Debug.Log("Enlarge nyentuh player 2");
            }
        }
    }
}
