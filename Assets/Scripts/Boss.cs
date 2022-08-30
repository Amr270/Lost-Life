using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{

    public int Max_Health = 100;
    public int health;
    public int Damage = 10;
    public Health_Bar health_bar;
    //public float speed = 2;

    // Start is called before the first frame update
    void Start()
    {
        health = Max_Health;
        health_bar.Set_Max_Health(Max_Health);
    }

    // Update is called once per frame

    void Update()
    {
        if(health <= 0)
        {
            Debug.Log("The boss died");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(gameObject.tag == "Boss")
        {
            if (collision.gameObject.CompareTag("Reflect"))
            {
                health -= Damage;
                health_bar.Set_Health(health);
                Debug.Log("The boss health is " + health);
            }
        }
    }
    
}
