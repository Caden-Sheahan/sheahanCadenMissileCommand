/******************************************************************************
//      File Name: PlayerBehaviour.cs
//      Author: Caden Sheahan
//      Creation Date: September 11th, 2022
//
//      Description: 
******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviour : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 mPos;

    [Header("Shooting")]
    public GameObject pBullet;
    public GameObject tPoint;
    public GameObject bTip;
    private Quaternion flip;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        flip = Quaternion.Euler(0, 0, 180);
    }

    // Update is called once per frame
    void Update()
    {
        AimBarrel();
        ShootBullet();
    }

    /// <summary>
    /// Function that controls the aiming of the barrel using mouse position
    /// </summary>
    private void AimBarrel()
    {
        // get the mouse position in-world.
        mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // isolate position without rigidbody values, only mouse pos.
        Vector2 bDirect = mPos - rb.position;
        // find rotation angle using Atan2 and convert to degrees
        // (plus 90 because... weird offset I don't understand)
        float bAngle = Mathf.Atan2(bDirect.y, bDirect.x) * Mathf.Rad2Deg + 90f;
        rb.rotation = bAngle; // Set angle to barrel angle in Unity
    }

    /// <summary>
    /// Function to control instantiating a bullet to fire and explode upon
    /// reaching the mouse position when the bullet was fired
    /// </summary>
    private void ShootBullet()
    {
        if (Input.GetMouseButtonDown(0))
        {
            print("shoot!");
            Instantiate
                (pBullet, bTip.transform.position, transform.rotation * flip);
            Instantiate(tPoint, mPos, Quaternion.identity);
        }
    }
}
