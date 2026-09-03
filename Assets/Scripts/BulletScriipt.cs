using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScriipt : MonoBehaviour
{

    public float BulletSpeed = 5f;
    void Start()
    {

    }
    void Update()
    {
        transform.position += new Vector3(0, BulletSpeed, 0) * Time.deltaTime;
    }
//    private void OnTriggerEnter2D(Collider2D collision)
//    {
//        GameManager.instance.IncreaseScore(10);
//    }
}