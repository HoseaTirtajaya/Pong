using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsManager : MonoBehaviour
{
    public SpriteRenderer fireRender;
    public SpriteRenderer enlargeRender;
    public Rigidbody2D fire;
    public Rigidbody2D enlarger;
    public Collider2D fireball;
    public Collider2D enlargercol;
    private float nextTimer;
    private int randomGenerator;

    // Start is called before the first frame update
    void Start()
    {
        //fire = GetComponent<Rigidbody2D>();
        //fireball = GetComponent<Collider2D>();
        //fireRender = GetComponent<SpriteRenderer>();
        //enlargeRender = GetComponent<SpriteRenderer>();
        //enlarger = GetComponent<Rigidbody2D>();
        //gameobject.find("fireball").setactive(false);
        //gameobject.find("enlarger").setactive(false);

        fireRender.enabled = false;
        enlargeRender.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        randomizer();
    }

    private void randomizer()
    {
        nextTimer += Time.deltaTime;
        randomGenerator = Random.Range(1, 2);
        //Debug.Log(randomGenerator);
        //Debug.Log(nextTimer);

        if (randomGenerator >= 0.6f && randomGenerator <= 1f && nextTimer >= 2f)
        {
            Debug.Log("random: " + randomGenerator);
            Debug.Log("fireball casted");

            fireRender.enabled = true;
            int randie = Random.Range(0, 2);

            if (randie == 0)
            {
                fire.velocity = new Vector2(-25f, 0f);
                if (Mathf.Abs(this.transform.position.x) >= 10)
                {
                    this.transform.position = new Vector3(0f, 0f, 0f);
                    fireRender.enabled = false;
                }
            }
            else if (randie == 1)
            {
                fire.velocity = new Vector2(25f, 0f);
                if (Mathf.Abs(this.transform.position.x) >= 10)
                {
                    this.transform.position = new Vector3(0f, 0f, 0f);
                    fireRender.enabled = false;
                }
            }

            fireRender.enabled = true;
            nextTimer = 0f;
        }
        else if(randomGenerator >= 0.1f && randomGenerator <= 0.5f && nextTimer >= 15.0f)
        {
            Debug.Log("Random: " + randomGenerator);
            Debug.Log("enlarger casted");

            enlargeRender.enabled = true;

            int rand = Random.Range(0, 2);

            if (rand == 0)
            {
                enlarger.velocity = new Vector2(-18f, 0f);
            }
            else if (rand == 1)
            {
                enlarger.velocity = new Vector2(18f, 0f);
            }

            if (Mathf.Abs(this.transform.position.x) >= 12)
            {
                enlargeRender.enabled = false;
                this.transform.position = new Vector3(0f, 0f, 0f);
            }
            nextTimer = 0f;
        }
    }

}
