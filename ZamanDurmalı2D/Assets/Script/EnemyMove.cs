using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    private bool dirRight = true;
    public float speed = 2.0f;
    public float ArtıMesafe;
    public float EksiMesafe;

    void Update()
    {
        if (dirRight)
            transform.Translate(Vector2.right * speed * Time.deltaTime,Space.World);
        else
            transform.Translate(-Vector2.right * speed * Time.deltaTime,Space.World);

        if (transform.position.x >= ArtıMesafe)
        {
            transform.rotation = Quaternion.Euler(0,0, 0);
            dirRight = false;
        }

        else if (transform.position.x <= -EksiMesafe)
        {
            transform.rotation = Quaternion.Euler(0, 180f, 0);
            dirRight = true;
        }
    }
}
