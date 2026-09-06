using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class EnemyScript : MonoBehaviour
{
    GameObject player;

    public static System.Action OnDeadEnemy;

    [SerializeField] float speed = 5f;

    [SerializeField] private AudioSource AuShoot;


    [SerializeField]GameManager gameManager;




    void Update()
    {
        transform.localPosition -= new Vector3(0, speed, 0) * Time.deltaTime;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            if (AuShoot != null)
            {
                AuShoot.Play();
            }

            PlayerScript player = collision.GetComponent<PlayerScript>();
            if (player != null)
            {
                player.TakeDamage();
            }
        
            Destroy(gameObject);

        }


        //Destroy(collision.gameObject);

        //un return?


    }

}