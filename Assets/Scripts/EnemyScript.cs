using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class EnemyScript : MonoBehaviour
{
    GameObject player;

    public static System.Action OnDeadEnemy;

    [SerializeField]float speed = 5f;

    [SerializeField]GameManager gameManager;


    //public float frecuens = 2f;
    //public float tall= 3f;
    //private float PIX;  //PIX=posicion inicial x 
    //private float PIY;  //PIY=posicion inicial y 



    /* void Start()
     {
         player = GameObject.Find("Player");
         PIX = transform.position.x;
         PIY = transform.position.y; 
     }*/

    // Update is called once per frame
    void Update()
    {

        //float newX = PIX + Mathf.Sin(Time.time * frecuens) * tall;
        transform.localPosition -= new Vector3(0, speed, 0) * Time.deltaTime;

        //transform.Translate(Mathf.Sin(Time.time * 3f) * 2f, 5f, 0);

        //float x = Mathf.Clamp(transform.position.x,-8, 8);
        //float y = Mathf.Clamp(transform.position.y, 4, -4);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
       // Debug.Log("choque!");
       // GameManager.instance.IncreaseScore(5);


        Destroy(collision.gameObject);

        Destroy(gameObject);
    }
}
