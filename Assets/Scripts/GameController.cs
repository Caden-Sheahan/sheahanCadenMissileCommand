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
    public GameObject go;
    // Update is called once per frame

    void Start()
    {
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
}
