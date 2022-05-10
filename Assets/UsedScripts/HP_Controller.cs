using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class HP_Controller : MonoBehaviour
    {
        [SerializeField] float MaxHP = 100f;
        public float _currentHealth;
        public float CurrentHealth { get => _currentHealth; }

        void Start()
        {
            _currentHealth = MaxHP;

        }
        public void GetDamage(float damage)
        {
            _currentHealth -= damage;
            if (CurrentHealth < 0)
            {
                Debug.Log("GameOver");
            }
        }
        public void GetHealPoint(float damage)
        {
            _currentHealth += damage;
            if (CurrentHealth >= 150f)
            {
                _currentHealth = 150f;
            }
        }
    }
}
