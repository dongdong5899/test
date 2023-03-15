using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    void Start()
    {
        this.player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {

        //이동
        transform.position += Vector3.down * 4.0f * Time.deltaTime;
        if (transform.position.y <= -6.0f)
        {
            Destroy(gameObject);
        }
        

    }

    //충돌2
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Destroy(gameObject);

    }
}
