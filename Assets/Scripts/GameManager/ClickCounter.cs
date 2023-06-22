using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public static int shakeCount;

    private bool isShake;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    IEnumerator ShakeCounter()
    {
        if(isShake)
            shakeCount++;

        yield return new WaitForSeconds(1.0f);

        Debug.Log("aaa");
        isShake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isShake)
        {
            isShake = true;

            StartCoroutine("ShakeCounter");           
        }
    }
}
