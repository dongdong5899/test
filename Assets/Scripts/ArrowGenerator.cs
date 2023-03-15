using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 0.5f;
    float delta = 0;

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            float rand = Random.Range(-10.0f, 10.0f);
            Instantiate(arrowPrefab, new Vector3(rand, 6, 0), Quaternion.identity);
        }
    }
}
