using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 傷害系統
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("會造成傷害的目標")]
        private string nameTarget;
        [SerializeField, Header("爆炸")]
        private GameObject prefabExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("碰撞 : " + collision.gameObject);

            // 如果碰到物件包含 敵 就爆炸 抱歉我下次會記得統整名稱
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                // 此物件被消滅
                Destroy(gameObject);
            }
        }
    }
}