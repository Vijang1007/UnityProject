using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;//ȸ�� �ӵ�
    bool end = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //Ŭ���ϸ� ȸ�� �Ѵ�.
       if(Input.GetMouseButtonDown(0))
        {
            rotSpeed = 10;
            end = true;
        }

        //�ӵ��� ���δ�.
        rotSpeed *= 0.95f;

        //ȸ�� �ӵ���ŭ �귿�� ȸ���Ѵ�.
        gameObject.transform.Rotate(0, 0, rotSpeed);    
        
        if(end == true)
        {
            if(rotSpeed <= 0.01f)
            {
                if(gameObject.transform.eulerAngles.z > 330 || gameObject.transform.eulerAngles.z <= 30)
                {
                    Debug.Log("��� ����");
                }
                else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                {
                    Debug.Log("��� ����");
                }
                else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                {
                    Debug.Log("��� �ſ� ����");
                }
                else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                {
                    Debug.Log("��� ����");
                }
                else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                {
                    Debug.Log("��� ����");
                }
                else
                {
                    Debug.Log("��� ����");
                }
                end = false;
            }
        }
    }
}