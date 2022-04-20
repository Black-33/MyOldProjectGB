using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject ClonObj;
    private int _var;
    [SerializeField] private Vector3 Position;
    [SerializeField] private Vector3 Position2;
    
    void Start()
    {
        //Создание призрака (клона)
        //var clone = Instantiate(ClonObj);
        // Создание клона(в нужных координатах)
        var clone1 = Instantiate(ClonObj, Position, Quaternion.identity);
        var clone2 = Instantiate(ClonObj, Position2, Quaternion.identity);      
    }
    
    void Update()
    {
        
    }
}
