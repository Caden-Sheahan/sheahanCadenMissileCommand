/******************************************************************************
//      File Name: GameController.cs
//      Author: Caden Sheahan
//      Creation Date: September 11th, 2022
//
//      Description: The GameController script controls inputs and actions that
//      don't effect the gameplay. It consists of debug inputs, spawning the
        enemy bullets, and restarting the game.
******************************************************************************/ 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static int castleCount;

    private GameObject[] castles;
    public static int cTarget;
    public GameObject eBullet;
    public float eFireRate = 1.5f;
    private Quaternion direction;

    void Start()
    {
        castleCount = 6;
        StartCoroutine(FireAtCastle());
    }

    void Update()
    {
        AimBullet();
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
        if (castleCount == 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    private void AimBullet()
    {
        
    }

    IEnumerator FireAtCastle()
    {
        while(true)
        {
            cTarget = Random.Range(0, castleCount);
            castles = GameObject.FindGameObjectsWithTag("castle");
            Instantiate(eBullet, new Vector3(Random.Range(-8, 8), 4.5f, 0),
                Quaternion.identity);
            yield return new WaitForSeconds(eFireRate);
        }
    }
}
