using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public int SpeedMove = 0; //�������� �������� �����
    public int VectorMove = 0; //����������� ��������
    public float Max_z = 2; //�����������
    public float Min_Y = -1;  //����������

    void Start()
    {



    }
    void Update()
    {
        Vector3 p = this.transform.position;
        p.z = p.z + SpeedMove * VectorMove * Time.deltaTime;
        this.transform.position = p;
        
    }
}

