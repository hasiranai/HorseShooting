using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class HorseHealth : MonoBehaviour
{
    //public GameObject effectPrefab;
    //public GameObject effectPrefab2;
    public int horseHP;

    public TextMeshProUGUI hpLabel;

    private int horseMaxHP = 10;   // 最大値は自由

    private void Start()
    {
        horseHP = horseMaxHP;

        hpLabel.text = "" + horseHP;
    }

    private void OnTriggerEnter(Collider other)
    {
        // もしもぶつかってきた相手のTagが"EnemyShell"であったならば（条件）
        if (other.CompareTag("EnemyShell"))
        {
            // HPを１ずつ減少させる
            horseHP -= 1;

            hpLabel.text = "" + horseHP;

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



    public void AddHP(int amount)
    {
        horseHP += amount;

        if (horseHP > horseMaxHP)
        {
            horseHP = horseMaxHP;
        }

        hpLabel.text = "" + horseHP;
    }
}
