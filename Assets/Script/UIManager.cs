using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public Image hpGauge;
    void Start()
    {
        
    }

    void Update()
    {

        if (hpGauge.fillAmount <= 0.1f) SceneManager.LoadScene(1);
    }

    public void DecrementHP()
    {
        hpGauge.fillAmount -= 0.2f;
    }
}
