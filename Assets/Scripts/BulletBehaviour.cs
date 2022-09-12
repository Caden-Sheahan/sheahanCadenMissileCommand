using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private Vector2 mPos;
    public bool isPlayer;
    public float bSpeed = 1f;
    public GameObject tPoint;
    public GameObject exp;

    // Start is called before the first frame update
    void Start()
    {
        mPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards
            (transform.position, mPos, bSpeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("TargetPoint") && isPlayer)
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
