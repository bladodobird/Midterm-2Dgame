using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 子彈設定測試
    /// </summary>

    public class Bullet : MonoBehaviour
    {

        [SerializeField] private float speed = 5f;//子彈的速度
        public Rigidbody2D rig;

        void Start()
        {
            rig = GetComponent<Rigidbody2D>();//獲取子彈剛體組件
            rig.velocity = transform.right * speed;//移動
           
        }
    }
}