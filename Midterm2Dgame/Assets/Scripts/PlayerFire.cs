using UnityEngine;

namespace YIZU
{
    /// <summary>
    /// 玩家射擊
    /// </summary>
    public class PlayerFire : FireSystem
    {
        private void Update()
        {
            //玩家空白鍵生成子彈一
            if (Input.GetKeyDown(KeyCode.Space)) { 
                SpawnBullet();
            }
        }
    }
}