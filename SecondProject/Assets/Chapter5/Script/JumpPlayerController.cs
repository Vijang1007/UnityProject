using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayerController : MonoBehaviour
{
    public bool stiffness = false;
    float delta = 0;
    float delta2 = 0;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(stiffness == true)
        {
            Color CatColor = gameObject.GetComponent<SpriteRenderer>().color;

            delta += Time.deltaTime;
            delta2 += Time.deltaTime;
            if(delta > 0.3f)
            {
                delta = 0;
                if(CatColor.a == 0)
                {
                    CatColor.a = 1;
                    gameObject.GetComponent<SpriteRenderer>().color = CatColor;
                }
                else if(CatColor.a == 1)
                {
                    CatColor.a = 0;
                    gameObject.GetComponent<SpriteRenderer>().color = CatColor;
                }               
            }
            else if(delta2 > 1.3f)
            {
                delta2 = 0;
                stiffness = false;
                CatColor.a = 1;
                gameObject.GetComponent<SpriteRenderer>().color = CatColor;
            }
        }
        else if(stiffness == false)
        {
            //왼쪽 화살표 -> 왼쪽 이동
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                gameObject.transform.Translate(-0.07f, 0, 0);
            }


            //오른쪽 화살표 -> 오른쪽 이동
            if (Input.GetKey(KeyCode.RightArrow))
            {
                gameObject.transform.Translate(0.07f, 0, 0);
            }
        }    
    }



    public void Hit(bool a)
    {
        stiffness = a;
    }
}
