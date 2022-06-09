using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Yonetici : MonoBehaviour
{
    public GameObject Boru;
    int skor = 0;
    public Text skor_txt;

    void Start()
    {
        InvokeRepeating("boru_ekle", 0.0f, 1.5f);
        skor_txt.text = skor.ToString();
    }

    void boru_ekle()
    {
        GameObject yeni_boru = Instantiate(Boru);
    }

    public void skor_arttir(int deger)
    {
        skor += deger;
        skor_txt.text=skor.ToString(); 


    }

}
