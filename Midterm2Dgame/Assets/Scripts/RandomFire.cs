using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// �l�u�H���ͦ�����
    /// </summary>

    public class RandomFire : FireSystem
    {
        [SerializeField, Header("�ͦ����j"), Range(0, 3)]
        private float interval = 1.5f;


        private void Awake()
        {
            // SpawnBullet();
            InvokeRepeating("SpawnBullet", Random.Range(0, 3), interval);
        }
    }
}