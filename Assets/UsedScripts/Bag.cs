using UnityEngine;

namespace Project
{
    public class Bag : MonoBehaviour
    {
        [SerializeField] public bool k_Key = false;
        [SerializeField] int MaxAmmo = 0;
        public int _ammo;

        
        private void Update()
        {
            _ammo = MaxAmmo;
        }
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Key"))
            {
                k_Key = true;
                Debug.Log("Êëþ÷ âçÿò! (Ðþêçàê) ");
            }
        }

        public int CurrentAmmo { get => _ammo; }       
        public void GetAmmoPoint(int a_ammo)
        {
            _ammo += a_ammo;
            if (CurrentAmmo >= 150f)
            {
                _ammo = 150;
            }
        }
    }
}

