using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*
// ���� Ŭ����
public class Player             // public : �ٸ� Ŭ�������� ȣ�� ����
{
    private int hp = 100;       // private : �ٸ� Ŭ�������� ȣ�� �Ұ���
    private int power = 50;

    public void Attack()
    {
        Debug.Log(this.power + "�� ���ظ� ������!");
    }

    public void Damemge(int damege)
    {
        this.hp -= damege;
        Debug.Log(damege + "�� ���ظ� �Ծ���!");
    }
}
*/
public class Movment : MonoBehaviour    // MonoBehaviour(����Ƽ�� ���� ���) Ŭ������ ���
{
    public GameObject particle;
    GameObject U;
    GameObject D;
    Rigidbody2D rb2d;
    // ����� ó�� �ѹ� ����
    void Start()
    {
        this.U = GameObject.Find("U");
        this.D = GameObject.Find("D");
    }

    // �� �����Ӹ��� ����
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
        if (rb2d.gravityScale == -1)            //������ ��Ʈ��
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
