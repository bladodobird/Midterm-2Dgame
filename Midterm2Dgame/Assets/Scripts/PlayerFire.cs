using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// ���a�g��
    /// </summary>
    public class PlayerFire : FireSystem
    {
        private void Update()
        {
            //���a�ť���ͦ��l�u�@
            if (Input.GetKeyDown(KeyCode.Space)) { 
                SpawnBullet();
            }
        }
    }
}