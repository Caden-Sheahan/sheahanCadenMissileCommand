/******************************************************************************
//      File Name: BulletBehaviour.cs
//      Author: Caden Sheahan
//      Creation Date: September 11th, 2022
//
//      Description: 
******************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private GameObject[] castles;
    private Vector2 mPos;
    private Vector2 target;
    public float bSpeed = 1f;

    public bool isPlayer;
    public GameObject tPoint;
    public GameObject exp;

    // Start is called before the first frame update
    void Start()
    {
        mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        castles = GameObject.FindGameObjectsWithTag("castle");
        target = castles[GameController.cTarget].transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayer)
        {
            transform.position = Vector2.MoveTowards
                (transform.position, mPos, bSpeed * Time.deltaTime);
        }
        else if (!isPlayer)
        {
            transform.position = Vector2.MoveTowards
                (transform.position, target, bSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TargetPoint") && isPlayer)
        {
            Instantiate(exp, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("castle") && !isPlayer)
        {
            Instantiate(exp, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        else if (collision.gameObject.CompareTag("pExplosion") && !isPlayer)
        {
            Destroy(gameObject);
        }
    }
}
