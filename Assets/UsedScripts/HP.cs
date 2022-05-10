using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class HP : MonoBehaviour
    {
        [SerializeField] float HealPoint;
        private HP_Controller trappedHpControll;
        private float m_Time = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                trappedHpControll = other.gameObject.GetComponent<HP_Controller>();
                trappedHpControll.GetHealPoint(HealPoint);
                Debug.Log(trappedHpControll.CurrentHealth);

                Destroy(gameObject);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                trappedHpControll = null;
            }
        }
        private void Update()
        {
            m_Time += Time.deltaTime;
        }
    }
}
