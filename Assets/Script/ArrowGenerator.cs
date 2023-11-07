using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject Arrow;

    float time = 0.0f;
    [SerializeField] float re = 0.5f;
    void Update()
    {
        time += Time.deltaTime;
        if (time >= re)
        {
            time = 0.0f;
            Instantiate(Arrow, new Vector3(Random.Range(-10.0f, 10.0f), 6, 0), Quaternion.identity);
        }
    }
}
