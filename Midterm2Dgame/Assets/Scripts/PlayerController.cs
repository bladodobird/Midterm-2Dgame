using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 玩家操控
    /// </summary>
    public class PlayerController : MonoBehaviour
    {
        [Header("移動速度")]
        [SerializeField, Range(0, 10)]
        private float speedVertical = 3.5f;
        [SerializeField, Range(0, 10)]
        private float speedHorizontal = 4f;
        [Header("圖片")]
        [SerializeField]
        private Sprite pictureUp;
        [SerializeField]
        private Sprite pictureMiddle;
        [SerializeField]
        private Sprite pictureDown;
        [SerializeField]
        private Sprite shoot;
        [Header("圖片渲染物件")]
        [SerializeField]
        private SpriteRenderer spr;


        private void Update()
        {
            
            // WS Vertical
            // AD Horizontal

            // 上下加減1
            float v = Input.GetAxis("Vertical");
            // 左右加減1
            float h = Input.GetAxis("Horizontal");

            transform.Translate(
                speedHorizontal * Time.deltaTime * h,
                speedVertical * Time.deltaTime * v,
                0);

            // v 大於 0 圖片往上
            if (v > 0)
            {
                print("往上");

                spr.sprite = pictureUp;
            }
            // v小於 0 往下
            if (v < 0)
            {
                print("往下");

                spr.sprite = pictureDown;
            }
            // v等於 0 中間
            if (v == 0)
            {
                print("中間");

                spr.sprite = pictureMiddle;
            }


        }
        
    }
}