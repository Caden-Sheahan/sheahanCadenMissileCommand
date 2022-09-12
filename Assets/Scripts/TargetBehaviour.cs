/******************************************************************************
//      File Name: TargetBehaviour.cs
//      Author: Caden Sheahan
//      Creation Date: September 11th, 2022
//
//      Description: 
******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pBullet"))
        {
            Destroy(gameObject);
        }
    }
}
