using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public float MoveSpeed = 0.03f;

    // Šø‚ª‰Ÿ‚³‚ê‚½‚ç
    void Start()
    {

    }

    // ‚¸‚Á‚Æ
    void Update()
    {

        //ˆÚ“®‚·‚éˆ—
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(MoveSpeed, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-MoveSpeed, 0.0f, 0.0f);
        }
    }
}
