using UnityEngine;

namespace YIZU
{

    public class BulletDestroy : MonoBehaviour
    {
        void Start()
        {
            Destroy(gameObject, 1.5f); //子彈兩秒後消失
        }

    }
}