using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{

    public float MoveSpeed = 0.03f;

    public float JumpPower = 7.0f;

    Rigidbody MyRigidbody;

    public Transform StartPoint;

    public bool OnGround = false;

    // 旗が押されたら
    void Start()
    {
        //自分自身のオブジェクトにあるRigidbodyを取得
        MyRigidbody = this.GetComponent<Rigidbody>();

    }

    // ずっと
    void Update()
    {

        //移動する処理
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(MoveSpeed, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-MoveSpeed, 0.0f, 0.0f);
        }

        //ジャンプ処理
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //地面にいれば
            if (OnGround == true)
            {
                //ジャンプ
                MyRigidbody.velocity = Vector3.up * JumpPower;
            }
        }

        //落ちたら戻る処理
        if(transform.position.y < -5.0f)
        {
            transform.position = StartPoint.position;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            OnGround = true;
        }

        if(collision.gameObject.tag == "Item")
        {
            Destroy(collision.gameObject);
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            OnGround = false;
        }
    }
}
