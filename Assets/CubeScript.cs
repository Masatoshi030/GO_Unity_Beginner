using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CubeScript : MonoBehaviour
{

    public float MoveSpeed = 0.03f;

    public float JumpPower = 7.0f;

    Rigidbody MyRigidbody;

    public Transform StartPoint;

    public bool OnGround = false;

    public int ItemCounter = 0;

    public TextMeshProUGUI ItemCounter_Text;

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

        if(collision.gameObject.tag == "Item")
        {
            //�I�u�W�F�N�g�폜
            Destroy(collision.gameObject);

            //�A�C�e���J�E���^�[�A�b�v
            ItemCounter += 1;

            //�A�C�e���J�E���^�[�ɔ��f
            ItemCounter_Text.text = ItemCounter.ToString();
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
