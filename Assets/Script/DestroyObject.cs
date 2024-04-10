using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    //public GameObject effectPrefab;
    //public GameObject effectPrefab2;
    public int objectHP;

    // このメソッドはコライダー同士がぶつかった瞬間に呼び出される
    private void OnTriggerEnter(Collider other)
    {
        // もしもぶつかった相手のTagにShellという名前が書いてあったならば（条件）
        if (other.CompareTag("Shell"))
        {
            // オブジェクトのHPを１ずつ減少させる
            objectHP -= 1;

            // もしもHPが0よりも大きい場合には（条件）
            if (objectHP > 0)
            {
                // このスクリプトがついているオブジェクトを破壊する
                Destroy(other.gameObject);

                //GameObject effect = Instantiate(effectPrefab, other.transform.position, Quaternion.identity);

                //Destroy(effect, 2.0f);
            }
            else    // そうでない場合（HPが0以下になった場合）には（条件）
            {
                Destroy(other.gameObject);

                // もう１種類のエフェクトを発生させる
                //GameObject effect2 = Instantiate(effectPrefab2, other.transform.position, Quaternion.identity);

                //Destroy(effect2, 2.0f);
                Destroy(this.gameObject);
            }
        }
    }
}
