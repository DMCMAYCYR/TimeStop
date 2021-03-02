using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DugmeSistem : MonoBehaviour
{

    public DugmeMove[] hareket;
    bool Check;
    public Animator anim;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            anim.SetBool("Dugme", true);
            Check = !Check;
        }
        if (Check)
            Aktif();

        else if (!Check)
            AktifDegil();
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
            anim.SetBool("Dugme", false);
    }
    void Aktif()
    {
        for (int i = 0; i < hareket.Length; i++)
        {
            hareket[i].dirRight=true;
        }
    }
    void AktifDegil()
    {
        for (int i = 0; i < hareket.Length; i++)
        {
            hareket[i].dirRight =false;
        }
    }
}
