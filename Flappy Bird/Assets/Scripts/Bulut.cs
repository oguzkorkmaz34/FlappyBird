using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulut : MonoBehaviour
{

    void Start()
    {

    }


    void Update()
    {
        if (transform.position.x <= -10f)
        {
            float y_degeri = Random.Range(-1f, 3f);
            transform.position = new Vector3(10f, y_degeri, transform.position.z);

        }
        transform.Translate(-1f * Time.deltaTime, 0, 0);


    }
}
