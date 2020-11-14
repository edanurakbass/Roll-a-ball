using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TopKontrol : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    int sayac = 0;
    public int toplanacakObjeSayisi;
    public Text sayacText;
    public Text oyunBittiText;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
    }

   
    void FixedUpdate()
    {
        float yatay = Input.GetAxisRaw("Horizontal");
        float dikey = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(yatay, 0, dikey);

        fizik.AddForce(vec * hiz);

        //Debug.Log(yatay);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "engel")
        {
            other.gameObject.SetActive(false);
            sayac++;

            sayacText.text = "SAYAC = " + sayac;

            if (sayac == toplanacakObjeSayisi)
            {
                oyunBittiText.text = "OYUN BITTI";
            }
         
        }
    }
}
