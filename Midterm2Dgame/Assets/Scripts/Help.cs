using UnityEngine;

namespace YIZU
{

    public class Help : MonoBehaviour
    {
        [SerializeField, Header("更換圖片")]
        private Sprite picture;
        [SerializeField, Header("圖片渲染物件")]
        private SpriteRenderer spr;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                print("案空白建");
                spr.sprite = picture;
                
            }

        }
    }
}