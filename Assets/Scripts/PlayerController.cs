using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float hp = 1.0f;
    void Start()
    {
        Debug.Log("Strat");
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Update");
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 8f * Time.deltaTime; //new Vector3(1, 0, 0);
            transform.localScale = new Vector3(1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 8f * Time.deltaTime; //new Vector3(1, 0, 0);
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
}
