using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour
{
    public bool isPlayer;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("eBullet"))
        {

        }
    }

    public void Explode()
    {
        Destroy(gameObject);
    }
}
