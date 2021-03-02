using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DikeyDugme : MonoBehaviour
{
    public ZeminYukari[] hareketkodlari;
    bool Check;
    public Animator anim;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Check = !Check;
            anim.SetBool("Dugme", true);
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
        for (int i = 0; i < hareketkodlari.Length; i++)
        {
            hareketkodlari[i].enabled = false;
        }
    }
    void AktifDegil()
    {
        for (int i = 0; i < hareketkodlari.Length; i++)
        {
            hareketkodlari[i].enabled = true;
        }
    }
}
