using UnityEngine;
using System.Collections.Generic;
using System;


public class Enemy2Script : MonoBehaviour
{
    GameObject player;
    public float amplitud;
    public float xfrecuency;
    public float yfrecuency;
    Vector3 pos;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        pos= transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        float xMove = Mathf.Sin(Time.time * xfrecuency)*amplitud;
        float yMove = Mathf.Cos(Time.time * yfrecuency)*amplitud;

        transform.position =pos + new Vector3(xMove, yMove, 0);

        
        //float xMove =Mathf.Clamp(Vector3.

       
       // transform.position = Mathf.Clamp.(transform.position )
       // float x = Mathf.Sin(transform.position.x, -8, 8)* Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {

            PlayerScript player = collision.GetComponent<PlayerScript>();
            if (player != null)
            {
                player.TakeDamage();
            }

            Destroy(gameObject);

        }




    }

}
