using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;


public class SpawnerScript : MonoBehaviour
{

    [SerializeField] float spawn = 5f;
    [SerializeField] GameObject enemyPrefa;


    float xMin;
    float xMax;
    float ySpawn;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Camera camera = Camera.main;
        xMin = Camera.main.ViewportToWorldPoint(new Vector3(.1f,0,0)).x;
        xMax = Camera.main.ViewportToWorldPoint(new Vector3(.9f,0,0)).x;
        ySpawn= Camera.main.ViewportToWorldPoint(new Vector2(0, 1.25f)).y;
         
       InvokeRepeating("SpawEnemy", 4f, spawn);
    }
    void Update()
    {
     
    }

    void SpawEnemy()
    {
        float xRandom = Random.Range(xMin + 1, xMax +2);
       // Vector2 posicionSpawn = new Vector2(xRandom, ySpawn);   


        Instantiate(enemyPrefa, new Vector3(xRandom,ySpawn, 0 ), Quaternion.identity);    
    }
}
