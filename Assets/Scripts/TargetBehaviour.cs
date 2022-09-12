/******************************************************************************
//      File Name: GameController.cs
//      Author: Caden Sheahan
//      Creation Date: September 11th, 2022
//
//      Description: The GameController script controls inputs and actions that
//      dont' effect the gameplay. It consists of debug inputs
******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetBehaviour : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("pExplosion"))
        {
            Destroy(gameObject);
        }
    }
}