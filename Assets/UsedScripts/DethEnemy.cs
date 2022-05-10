using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DethEnemy : MonoBehaviour
{
    private float m_Time = 1;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Bomb"))
        {
            Destroy(gameObject);
        }

    }

    
    private void Update()
    {
        m_Time += Time.deltaTime;
    }
}
