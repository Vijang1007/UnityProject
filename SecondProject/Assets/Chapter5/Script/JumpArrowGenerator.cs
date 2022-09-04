using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        Debug.Log(delta);
        if(delta > span)
        {
            GameObject genObj = Instantiate(arrowPrefab);
            delta = 0;

            int px = Random.Range(-6, 7);
            genObj.transform.position = new Vector3(px, 7, 0);
        }       
    }
}
