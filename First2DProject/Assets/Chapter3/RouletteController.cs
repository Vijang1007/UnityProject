using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 0;//회전 속도
    bool end = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       //클릭하면 회전 한다.
       if(Input.GetMouseButton(0))
        {
            rotSpeed = 10;
            end = true;
        }

        //속도를 줄인다.
        rotSpeed *= 0.95f;

        //회전 속도만큼 룰렛을 회전한다.
        gameObject.transform.Rotate(0, 0, rotSpeed);    
        
        if(end == true)
        {
            if(rotSpeed <= 0.01f)
            {
                if(gameObject.transform.eulerAngles.z > 330 || gameObject.transform.eulerAngles.z <= 30)
                {
                    Debug.Log("운수 나쁨");
                }
                else if (gameObject.transform.eulerAngles.z > 30 && gameObject.transform.eulerAngles.z <= 90)
                {
                    Debug.Log("운수 대통");
                }
                else if (gameObject.transform.eulerAngles.z > 90 && gameObject.transform.eulerAngles.z <= 150)
                {
                    Debug.Log("운수 매우 나쁨");
                }
                else if (gameObject.transform.eulerAngles.z > 150 && gameObject.transform.eulerAngles.z <= 210)
                {
                    Debug.Log("운수 보통");
                }
                else if (gameObject.transform.eulerAngles.z > 210 && gameObject.transform.eulerAngles.z <= 270)
                {
                    Debug.Log("운수 조심");
                }
                else
                {
                    Debug.Log("운수 좋음");
                }
                end = false;
            }
        }
    }
}
