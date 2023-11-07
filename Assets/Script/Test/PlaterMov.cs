using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaterMov : MonoBehaviour
{
    [SerializeField] float speed = 5;
    [SerializeField] Vector2 min;
    [SerializeField] Vector2 max;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        transform.position += new Vector3(x, y, 0).normalized * Time.deltaTime * speed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, min.x, max.x), Mathf.Clamp(transform.position.y, min.y, max.y), 0);
        /*
        if (transform.position.x < min.x) transform.position = new Vector3(min.x, transform.position.y, 0);
        if (transform.position.x > max.x) transform.position = new Vector3(max.x, transform.position.y, 0);
        if (transform.position.y < min.y) transform.position = new Vector3(transform.position.x, min.y, 0);
        if (transform.position.y > max.y) transform.position = new Vector3(transform.position.x, max.y, 0);
        */

        /*
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) transform.position += Vector3.left * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) transform.position += Vector3.right * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) transform.position += Vector3.up * Time.deltaTime * speed;
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow)) transform.position += Vector3.down * Time.deltaTime * speed;
        */
    }
}
