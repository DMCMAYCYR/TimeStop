using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZeminYukari : MonoBehaviour
{
    [Header("trueyukarıgider")]
    public bool dirRight;
    public float speed = 2.0f;
    public float ArtıMesafe;
    public float EksiMesafe;
    public GameObject player;
    public GameObject kutu;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.up * speed * Time.deltaTime, Space.World);
        else
            transform.Translate(-Vector2.up * speed * Time.deltaTime, Space.World);

        if (transform.position.y >= ArtıMesafe)
            dirRight = false;


        else if (transform.position.y <= -EksiMesafe)
            dirRight = true;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.parent = transform;
        }
        if (collision.gameObject.tag == "Kutu")
        {
            kutu.transform.parent = transform;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.transform.parent = null;
        }
        if (collision.gameObject.tag == "Kutu")
        {
            kutu.transform.parent = null;
        }
    }
}
