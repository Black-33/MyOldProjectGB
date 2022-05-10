using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Project
{
    public class OpenLock : MonoBehaviour
    {
        [SerializeField] private GameObject _door;
        [SerializeField] private float _speed;
        [SerializeField] private Transform _openTarget;
        [SerializeField] private GameObject _player;
        private bool key;
        public Bag Bag;

        private void Update()
        {
            Bag = _player.GetComponent<Bag>();
        }
        private void OnTriggerStay  (Collider other)
        {
            Debug.Log(key);
            key = Bag.k_Key;
            if (other.gameObject.CompareTag("Player") && key)
            { 
                    OpenDoor();
            }
        }

        private void OnTriggerExit(Collider other)
        {
            
        }

        public void OpenDoor()
        {
            _door.transform.position = Vector3.MoveTowards(_door.transform.position, _openTarget.position, _speed * Time.deltaTime);
        }

        public void CloseDoor()
        {
            //Добавить закрытие
        }
    }
}

