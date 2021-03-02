using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDeath : MonoBehaviour
{
    public EnemyMove enemyMove;
    public Animator anim;
    IEnumerator Bekle()
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Kutu")
        {
            anim.SetBool("Death", true);
            enemyMove.enabled = false;
            StartCoroutine(Bekle());
        }
    }
}
