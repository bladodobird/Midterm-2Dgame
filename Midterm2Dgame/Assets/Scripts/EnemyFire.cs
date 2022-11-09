using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 射擊
    /// </summary>
    public class EnemyFire : FireSystem
    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            // 呼叫自訂
            // SpawnBullet();

            // 延遲
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}