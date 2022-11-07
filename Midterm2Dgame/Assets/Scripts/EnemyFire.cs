using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// ®gÀ»
    /// </summary>
    public class EnemyFire : FireSystem
    {
        [SerializeField, Header("¥Í¦¨¶¡¹j"), Range(0, 3)]
        private float interval = 1.5f;

        private void Awake()
        {
            // ©I¥s¦Û­q
            // SpawnBullet();

            // ©µ¿ð
            InvokeRepeating("SpawnBullet", 0, interval);
        }
    }
}