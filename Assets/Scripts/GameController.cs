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
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    private Rigidbody2D rb;

    private GameObject[] castles;
    public static int cTarget;
    public float eFireRate = 1.5f;
    private Quaternion flip;

    public GameObject eBullet;
    public GameObject go;

    void Start()
    {
        rb = eBullet.GetComponent<Rigidbody2D>();
        StartCoroutine(FireAtCastle());
        StartCoroutine(GameOver());
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.R)) // reset game
        {
            print("Reload Game!");
            SceneManager.LoadScene(0);
        }

        if (Input.GetKey(KeyCode.Escape)) // quit game (in build)
        {
            print("Quit!");
            Application.Quit();
        }
    }

    IEnumerator GameOver()
    {
        if (CastleBehaviour.castleCount == 0)
        {
            go.SetActive(true);
            yield return new WaitForSeconds(2f);
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator FireAtCastle()
    {
        while(true)
        {
            cTarget = Random.Range(0, CastleBehaviour.castleCount);
            castles = GameObject.FindGameObjectsWithTag("castle");
            Instantiate(eBullet, new Vector3(Random.Range(-8, 8), 4.5f, 0),
                Quaternion.LookRotation(castles[cTarget].transform.position, Vector3.up));
            yield return new WaitForSeconds(eFireRate);
        }
    }




    //readyToFire = false;
    //castles = GameObject.FindGameObjectsWithTag("castle");
    //foreach (GameObject castle in castles)
    //{
    //    cPos.Add(castle.transform.position);
    //}
    //cTarget = Random.Range(0, 6);
    //Vector2 eFireDirect = cPos[cTarget] - rb.position;
    //float fAngle =
    //    Mathf.Atan2(eFireDirect.x, eFireDirect.y) * Mathf.Rad2Deg + 90f;
    //rb.rotation = fAngle;
}
