using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class BoxAmmo : MonoBehaviour
    {
        [SerializeField] int bullets;
        private Bag trappedAmControl;
        private float m_Time = 0;

        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                trappedAmControl = other.gameObject.GetComponent<Bag>();
                trappedAmControl.GetAmmoPoint(bullets);
                Debug.Log(trappedAmControl.CurrentAmmo);

                Destroy(gameObject);
            }
        }
        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                trappedAmControl = null;
            }
        }
        private void Update()
        {
            m_Time += Time.deltaTime;
        }
    }
}

