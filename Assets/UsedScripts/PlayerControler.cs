using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class PlayerControler : MonoBehaviour
    {
        [SerializeField] float MovementSpeed;//скорость пенремещения
        [SerializeField] float Jump;//Прыжок

        Vector3 m_Move;
        Vector2 m_Move2;
        private void Start()
        {

        }

        private void Update()
        {
            float xMov = Input.GetAxis("Horizontal");
            float zMov = Input.GetAxis("Vertical");
            float yJump = Input.GetAxis("Jump");
            m_Move.Set(xMov, yJump, zMov);
            //m_Move2.Set(xMov,yJump);
            transform.Translate(m_Move * Time.deltaTime * MovementSpeed);
            //transform.Translate(m_Move2 * Time.deltaTime * Jump);

            //Ускорение (бег)
            if (Input.GetKey(KeyCode.LeftShift))
            {
                MovementSpeed = 10f;
            }
            else { MovementSpeed = 5f; }

            if (Input.GetKey(KeyCode.Space))
            {
                Jump = 10f;
            }
            //else { Jump = 0f; }
        }
    }
}
