using UnityEngine;

namespace Project
{
    public class EnemySpawn : MonoBehaviour
    {
        [SerializeField] private GameObject Sphere;
        private int _var;
        
        

        void Start()
        {
            //�������� �������� (�����)
            //var clone = Instantiate(ClonObj);
            // �������� �����(� ������ �����������)
            var clone1 = Instantiate(Sphere, transform.position, Quaternion.identity);
            var clone2 = Instantiate(Sphere, transform.position, Quaternion.identity);
            var clone3 = Instantiate(Sphere, transform.position, Quaternion.identity);
            var clone4 = Instantiate(Sphere, transform.position, Quaternion.identity);
            var clone5 = Instantiate(Sphere, transform.position, Quaternion.identity);


        }

        void Update()
        {

        }
    }
}
