using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArrowController : MonoBehaviour
{
    GameObject player;
    float fallSpeed = -0.02f;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
    }

    // Update is called once per frame
    void Update()
    {
        //�����Ӹ��� ������� ���Ͻ�Ų��
        gameObject.transform.Translate(0, fallSpeed, 0);
        fallSpeed *= 1.01f;


        //ȭ�� ������ ������ �Ҹ��Ѵ�
        if(gameObject.transform.position.y < -5.0f)
        {
            Destroy(gameObject);
        }

        //�浹����
        Vector2 p1 = gameObject.transform.position; //ȭ��ǥ
        Vector2 p2 = player.transform.position; //�÷��̾�
        Vector2 dir = p1 - p2;

        float d = dir.magnitude;
        float r1 = 0.5f; //ȭ��ǥ�� �ݰ�
        float r2 = 1.0f; //�÷��̾��� �ݰ�

        if(d <= r1 + r2)
        {
            GameObject director = GameObject.Find("GameManager");
           

            Destroy(gameObject);

            GameObject Stiffness = GameObject.Find("player");
            if(player.GetComponent<JumpPlayerController>().stiffness == false)
            {
                Stiffness.GetComponent<JumpPlayerController>().Hit(true);
                director.GetComponent<GameManager>().DecreaseHp();
            }  
        }
    }


}
