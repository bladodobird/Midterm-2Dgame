using UnityEngine;

namespace YIZU
{

    public class Help : MonoBehaviour
    {
        [SerializeField, Header("�󴫹Ϥ�")]
        private Sprite picture;
        [SerializeField, Header("�Ϥ���V����")]
        private SpriteRenderer spr;

        private void Update()
        {
            if (Input.GetKey(KeyCode.Space))
            {
                print("�תťի�");
                spr.sprite = picture;
                
            }

        }
    }
}