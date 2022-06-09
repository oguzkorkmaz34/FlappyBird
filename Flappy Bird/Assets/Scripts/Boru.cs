using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boru : MonoBehaviour
{
    Yonetici yonet;
    void Start()
    {
        float rast = Random.Range(-0.70f, -2.5f);
        transform.position = new Vector3(7f, rast, transform.position.z);

        yonet=GameObject.FindObjectOfType<Yonetici>();
    }


    void Update()
    {
        if (transform.position.x <= -3.45f)
        {
            yonet.skor_arttir(10);
            Destroy(gameObject);
        }

        transform.Translate(-2f * Time.deltaTime, 0, 0);
    }
}
