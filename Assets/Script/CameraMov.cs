using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMov : MonoBehaviour
{
    GameObject Player;
    void Start()
    {
        this.Player = GameObject.Find("player");
    }

    void Update()
    {
        transform.position = new Vector3(this.Player.transform.position.x, 0, -10);
    }
}
