using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 子彈隨機生成測試
    /// </summary>

    public class RandomFire : FireSystem
    {
        [SerializeField, Header("生成間隔"), Range(0, 3)]
        private float interval = 1.5f;


        private void Awake()
        {
            // SpawnBullet();
            InvokeRepeating("SpawnBullet", Random.Range(0, 3), interval);
        }
    }
}