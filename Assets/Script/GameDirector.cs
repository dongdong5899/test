using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject StaminaGauge;
    void Start()
    {
        this.StaminaGauge = GameObject.Find("Stamina");
    }

    // Update is called once per frame
    public void DecreaseStamina()
    {
        this.StaminaGauge.GetComponent<Image>().fillAmount -= 0.5f * Time.deltaTime;
    }
}
