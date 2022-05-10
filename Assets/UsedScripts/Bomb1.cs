using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class Bomb1 : MonoBehaviour
    {
        [SerializeField] float Damage;
        private HP_Controller trappedHpControll;
        private float m_Time = 1;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Enemy"))
            {
                Destroy(gameObject);
            }
            if (other.gameObject.CompareTag("Player"))
            {
                trappedHpControll = other.gameObject.GetComponent<HP_Controller>();
                trappedHpControll.GetDamage(Damage);
                Debug.Log(trappedHpControll.CurrentHealth);

                Destroy(gameObject);
            }

        }
        //private void OnTriggerExit(Collider other)
        //{
        //    if (other.gameObject.CompareTag("Enemy"))
        //    {
        //        trappedHpControll = null;
        //    }
        //}
        private void Update()
        {
            m_Time += Time.deltaTime;
        }
    }
}

