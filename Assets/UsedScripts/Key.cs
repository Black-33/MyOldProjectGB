using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class Key : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                Debug.Log("Ключ взят! (Ключ) ");
                Destroy(gameObject);
            }
        }
    }
}

