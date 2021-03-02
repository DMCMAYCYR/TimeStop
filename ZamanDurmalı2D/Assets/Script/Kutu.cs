using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kutu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject NexyLevel;
    bool kontrol = true;
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Enemy")
        //{
        //    NexyLevel.SetActive(true);
        //}
        
        if(collision.gameObject.tag=="ZeminKutu" && kontrol==true)
        {
            Menu.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            NexyLevel.SetActive(true);
            kontrol = false;
        }
    }
}
