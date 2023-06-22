using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickCounter : MonoBehaviour
{
    public static int shakeCount;

    //コルーチン用に連続でクリックをカウントしないための変数
    private bool isShake;

    public GameObject coke;
    private CokeController cokeController;

    // Start is called before the first frame update
    void Start()
    {        
        cokeController = coke.GetComponent<CokeController>();
    }

    IEnumerator ShakeCounter()
    {
        if(isShake)
            shakeCount++;

        yield return new WaitForSeconds(0.25f);

        isShake = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isShake)
        {
            isShake = true;

            cokeController.MoveCoke();

            StartCoroutine("ShakeCounter");           
        }
    }
}
