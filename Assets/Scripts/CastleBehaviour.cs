/******************************************************************************
//      File Name: CastleBehaviour.cs
//      Author: Caden Sheahan
//      Creation Date: September 11th, 2022
//
//      Description: 
******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CastleBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("eBullet"))
        {
            GameController.castleCount--;
            print(GameController.castleCount);
            Destroy(gameObject);
        }
    }
}
