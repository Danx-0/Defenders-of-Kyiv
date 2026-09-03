using UnityEngine;
using DG.Tweening;

public class PlaneScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.DOMoveY(-9, 1).SetLoops(-1); //-1 para  que se mueva infinitamente, va cambiando los valores
      //  transform.DOMoveY(100, 20).SetLoops(-1); //-1 para  que se mueva infinitamente, va cambiando los valores """"este es el origunal """"
    }

    // Update is called once per frame
    void Update()
    {

    }
}
