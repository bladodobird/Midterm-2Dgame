using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// �l�u�ͦ�
    /// </summary>
    public class FireSystem : MonoBehaviour
    {
        [SerializeField, Header("�l�u�w�m��")]
        private GameObject prefabBullet;
        [SerializeField, Header("�l�u�ͦ��I")]
        private Transform pointSpawn;




        protected void SpawnBullet()
        {
            Instantiate(prefabBullet, pointSpawn.position, pointSpawn.rotation);
        }

    }
}