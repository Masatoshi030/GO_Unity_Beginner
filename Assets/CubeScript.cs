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
            //�����ɑO�� No.1�Ŏg����X���Ɉړ�����v���O�������������I
            transform.Translate(0.003f, 0.0f, 0.0f);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            //�����ɑO�� No.1�Ŏg����X���Ɉړ�����v���O�������������I
            transform.Translate(-0.003f, 0.0f, 0.0f);
        }
    }
}
