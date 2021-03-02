using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HeroMove : MonoBehaviour
{
    Rigidbody2D rb;
    Animator anim;
    Vector3 velocity;


    public GameObject[] Zemin;
    public float Speed;
    public float JumpForce;
    public bool Kontrol;
    public float Sure;
    public Slider Mana;

    float bak;
    void Start()
    {
        bak = Sure;
        Mana.maxValue = bak;
        Mana.minValue = 0;
        Kontrol = false;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Mana.value = Sure;
        velocity = new Vector3(Input.GetAxis("Horizontal"), 0f);
        transform.position += velocity * Speed * Time.deltaTime;
        if (Input.GetButtonDown("Jump") && Mathf.Approximately(rb.velocity.y, 0))
        {
            anim.SetBool("Jump", true);
            //rb.velocity = Vector2.up * JumpForce;
            rb.AddForce(Vector3.up * JumpForce, ForceMode2D.Impulse);
        }
        if (Input.GetAxisRaw("Horizontal") == -1)
        {
            anim.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 180f, 0);
        }
        else if (Input.GetAxisRaw("Horizontal") == 1)
        {
            anim.SetBool("Run", true);
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
        else
        {
            anim.SetBool("Run", false);
            anim.SetBool("Jump", false);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            Kontrol = !Kontrol;
        }

        //GameObjetc Aktif Etme
        if (Kontrol == true)
        {
            Sure -= Time.deltaTime;
            if (Sure>=0)
              Aktif();
            else if (Sure < 0)
            {
                Sure = 0;
                AktifDegil();
                StartCoroutine(Bekle());
            }
        }
        else
        { 
            
            Sure+=Time.deltaTime*0.5f;
            if (Sure >= bak)
                Sure = bak;
                AktifDegil();
        }
    }
    IEnumerator Bekle()
    {
        yield return new WaitForSeconds(0.5f);
        Kontrol = false;
    }

    void Aktif()
    {
        foreach (GameObject yap in Zemin)
        {
            yap.SetActive(true);
        }
    }
    void AktifDegil()
    {
        foreach (GameObject yap in Zemin)
        {
            yap.SetActive(false);
        }
    }
}
