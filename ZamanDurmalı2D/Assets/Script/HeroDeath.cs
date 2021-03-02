using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroDeath : MonoBehaviour
{

    public HeroMove HeroMove;
    public Animator anim;
    public GameObject Menu;
  
    IEnumerator Bekle()
    {
        yield return new WaitForSeconds(0.4f);
        anim.SetBool("Deayh", false);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
          if (collision.gameObject.tag == "Enemy" || collision.gameObject.layer==8)
        {
            Menu.SetActive(true);
            anim.SetBool("Run", false);
            anim.SetBool("Deayh", true);
            HeroMove.enabled = false;
            StartCoroutine(Bekle());
            //Ölüm Ekranı yap
            //Kutu aşağı düştüğünde de ölüm ekranı gelsin(restar akranı)
        }
    }
}
