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
        [Header("�Ϥ�")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;
        [SerializeField]
        private Sprite shoot;
        [Header("�Ϥ���V����")]
        [SerializeField]
        private SpriteRenderer spr;


        private void Update()
        {
            
            // WS Vertical
            // AD Horizontal

            // �W�U�[��1
            float v = Input.GetAxis("Vertical");
            // ���k�[��1
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);

            // v �j�� 0 �Ϥ����W
            if (v > 0)
            {
                print("���W");

                spr.sprite = pictureUp;
            }
            // v�p�� 0 ���U
            if (v < 0)
            {
                print("���U");

                spr.sprite = pictureDown;
            }
            // v���� 0 ����
            if (v == 0)
            {
                print("����");

                spr.sprite = pictureMiddle;
            }


        }
        
    }
}