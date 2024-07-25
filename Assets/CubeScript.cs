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

    // ���������ꂽ��
    void Start()
    {
        //�������g�̃I�u�W�F�N�g�ɂ���Rigidbody���擾
        MyRigidbody = this.GetComponent<Rigidbody>();

    }

    // ������
    void Update()
    {

        //�ړ����鏈��
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(MoveSpeed, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-MoveSpeed, 0.0f, 0.0f);
        }

        //�W�����v����
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //�n�ʂɂ����
            if (OnGround == true)
            {
                //�W�����v
                MyRigidbody.velocity = Vector3.up * JumpPower;
            }
        }

        //��������߂鏈��
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
    }

    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            OnGround = false;
        }
    }
}
