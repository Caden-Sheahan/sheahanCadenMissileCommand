using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleBehaviour : MonoBehaviour
{
    public static int castleCount = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("eBullet"))
        {
            castleCount--;
            Destroy(gameObject);
        }
    }
}
