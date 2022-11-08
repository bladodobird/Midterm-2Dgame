using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// �ˮ`�t��
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("�|�y���ˮ`���ؼ�")]
        private string nameTarget;
        [SerializeField, Header("�z��")]
        private GameObject prefabExplosion;

        private void OnCollisionEnter2D(Collision2D collision)
        {
            //print("�I�� : " + collision.gameObject);

            // �p�G�I�쪫��]�t �� �N�z�� ��p�ڤU���|�O�o�ξ�W��
            if (collision.gameObject.name.Contains(nameTarget))
            {
                Instantiate(prefabExplosion, transform.position, transform.rotation);

                // ������Q����
                Destroy(gameObject);
            }
        }
    }
}