using UnityEngine;

namespace Project
{
    public class Trap : MonoBehaviour
    {
        [SerializeField] private float Damage;
        [SerializeField] private float DamagePerSecond;

        private HP_Controller TrappedHpControll;
        private float m_Time = 0;
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                TrappedHpControll = other.gameObject.GetComponent<HP_Controller>();
                TrappedHpControll.GetDamage(Damage);
                Debug.Log(TrappedHpControll.CurrentHealth);
            }
        }
        private void OnTriggerStay(Collider other)
        {
            if (TrappedHpControll != null && m_Time >= 1)
            {
                TrappedHpControll.GetDamage(DamagePerSecond);
                Debug.Log(TrappedHpControll.CurrentHealth);
                m_Time = 0;
            }
        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                TrappedHpControll = null;
            }
        }
        private void Update()
        {
            m_Time += Time.deltaTime;
        }
    }
}

