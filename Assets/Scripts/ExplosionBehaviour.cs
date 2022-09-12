/******************************************************************************
//      File Name: ExplosionBehaviour.cs
//      Author: Caden Sheahan
//      Creation Date: September 11th, 2022
//
//      Description: 
******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionBehaviour : MonoBehaviour
{
    public void Explode()
    {
        Destroy(gameObject);
    }
}
