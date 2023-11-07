using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowDoun : MonoBehaviour
{
    UIManager uIManager;
    private void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        uIManager = FindObjectOfType<UIManager>();
        uIManager.DecrementHP();
        Destroy(gameObject);
    }
    void Update()
    {
        transform.position += Vector3.down * 10 * Time.deltaTime;
        if (transform.position.y <= -6)
        {
            Destroy(gameObject);
        }
    }
}
