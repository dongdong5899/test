using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
// 나의 클래스
public class Player             // public : 다른 클래스에서 호출 가능
{
    private int hp = 100;       // private : 다른 클래스에서 호출 불가능
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "의 피해를 입혔다!");
    }

    public void Damemge(int damege)
    {
        this.hp -= damege;
        Debug.Log(damege + "의 피해를 입었다!");
    }
}
*/
public class Movment : MonoBehaviour    // MonoBehaviour(유니티의 여러 기능) 클래스를 상속
{
    public GameObject particle;
    GameObject U;
    GameObject D;
    Rigidbody2D rb2d;
    // 실행시 처음 한번 실행
    void Start()
    {
        this.U = GameObject.Find("U");
        this.D = GameObject.Find("D");
    }

    // 매 프레임마다 실행
    void Update()
    {
        rb2d = GetComponent<Rigidbody2D>();
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += new Vector3(-5.0f, 0, 0) * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(5.0f, 0, 0) * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(particle, transform.position, Quaternion.Euler(-90 * rb2d.gravityScale, 0, 0));
            rb2d.gravityScale *= -1;
            if (rb2d.gravityScale == -1)
            {
                transform.position = new Vector2(transform.position.x, U.transform.position.y - 0.5f);
            }
            else
            {
                transform.position = new Vector2(transform.position.x, D.transform.position.y + 0.5f);
            }
        }
        if (rb2d.gravityScale == -1)            //게이지 컨트롤
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().DecreaseStamina();
            if (director.GetComponent<GameDirector>().StaminaGauge.GetComponent<Image>().fillAmount <= 0)
            {
                rb2d.gravityScale *= -1;
                
            }
        }
        else
        {
            GameObject director = GameObject.Find("GameDirector");
            director.GetComponent<GameDirector>().StaminaGauge.GetComponent<Image>().fillAmount += 0.25f * Time.deltaTime;
        }
    }
}
