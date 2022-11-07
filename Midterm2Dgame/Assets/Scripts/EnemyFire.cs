using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// �g��
    /// </summary>
    public class EnemyFire : FireSystem
    {
        [SerializeField, Header("�ͦ����j"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            // �I�s�ۭq
            // SpawnBullet();

            // ����
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}