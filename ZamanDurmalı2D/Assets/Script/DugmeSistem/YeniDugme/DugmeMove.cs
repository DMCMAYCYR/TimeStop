using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DugmeMove : MonoBehaviour
{
    [Header("truesağgider")]
    public bool dirRight;
    public float speed;
    public float ArtıMesafe;
    public float EksiMesafe;
    public GameObject player;
    public GameObject kutu;

    void Update()
    {

        if (dirRight && transform.position.x<=ArtıMesafe)
            transform.Translate(Vector2.right * speed * Time.deltaTime, Space.World);
        else if(!dirRight && -transform.position.x<=EksiMesafe)
            transform.Translate(-Vector2.right * speed * Time.deltaTime, Space.World);
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
