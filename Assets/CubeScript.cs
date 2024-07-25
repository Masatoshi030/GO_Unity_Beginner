using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            //ここに前回 No.1で使ったX軸に移動するプログラムを書こう！
            transform.Translate(0.003f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //ここに前回 No.1で使ったX軸に移動するプログラムを書こう！
            transform.Translate(-0.003f, 0.0f, 0.0f);
        }
    }
}
