using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    [SerializeField] float MovementSpeed = 5;//скорость пенремещения
    [SerializeField] float JumpForce;//Прыжок в разработке
    Vector3 m_Move;   
    private void Start()
    {
        
    }

    private void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        float jump = Input.GetAxis("Jump");

        m_Move.Set(horizontal, 0f, vertical);
        //m_Move.Normalize();
        transform.Translate(m_Move * Time.deltaTime * MovementSpeed);

        //Ускорение (бег)
        if (Input.GetKey(KeyCode.LeftShift))
        {
            MovementSpeed = 10f;
        }
        else{ MovementSpeed = 5f;}

    }

    

}
