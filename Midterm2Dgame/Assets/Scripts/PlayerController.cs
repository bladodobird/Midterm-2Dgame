using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// ���a�ޱ�
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [Header("���ʳt��")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;

        private void Update()
        {
            // W +1
            // s -1
            float v = Input.GetAxis("Vertical");
            // D +1
            // A -1
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime *h,
                speedVertical * Time.deltaTime *v,
                0);
        }

    }
}