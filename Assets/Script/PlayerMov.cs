using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMov : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left * 8 * Time.deltaTime;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right * 8 * Time.deltaTime;
            transform.localScale = new Vector3(1, 1, 1);
        }
    }

    public void LeftButtonDown()
    {
        transform.position += Vector3.left * 8 * Time.deltaTime;
        transform.localScale = new Vector3(-1, 1, 1);
    }
    public void RightButtonDown()
    {
        transform.position += Vector3.right * 8 * Time.deltaTime;
        transform.localScale = new Vector3(1, 1, 1);
    }
}
