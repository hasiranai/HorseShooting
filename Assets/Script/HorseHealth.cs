using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorseHealth : MonoBehaviour
{
    //public GameObject effectPrefab;
    //public GameObject effectPrefab2;
    public int horseHP;

    private void OnTriggerEnter(Collider other)
    {
        // もしもぶつかってきた相手のTagが"EnemyShell"であったならば（条件）
        if (other.CompareTag("EnemyShell"))
        {
            // HPを１ずつ減少させる
            horseHP -= 1;

            // ぶつかってきた相手方（敵の砲弾）を破壊する
            Destroy(other.gameObject);

            if (horseHP > 0)
            {
                //GameObject effect1 = Instantiate(effectPrefab, transform.position, Quaternion.identity);
                //Destroy(effect1, 1.0f);
            }
            else  // 上の条件が成立しなくなった場合にはこちらを実行する
            {
                //GameObject effect2 = Instantiate(effectPrefab2, transform.position, Quaternion.identity);
                //Destroy(effect2, 1.0f);

                // プレーヤーを破壊する
                Destroy(gameObject);
            }
        }
    }
}
