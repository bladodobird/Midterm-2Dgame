using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// �l�u�]�w����
    /// </summary>

    public class Bullet : MonoBehaviour
    {

        [SerializeField] private float speed = 5f;//�l�u���t��
        public Rigidbody2D rig;

        void Start()
        {
            rig = GetComponent<Rigidbody2D>();//����l�u����ե�
            rig.velocity = transform.right * speed;//����
           
        }
    }
}