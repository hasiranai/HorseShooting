using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShotShell : MonoBehaviour
{
    public float shotSpeed;
    public GameObject enemyShellPrefab;
    public AudioClip shotSound;
    private int count;

    void Update()
    {
        count += 1;

        // 「%」と「==」の意味は
        if (count % 100 == 0)
        {
            GameObject enemyShell = Instantiate(enemyShellPrefab, transform.position, Quaternion.identity);
            Rigidbody enemyShellRb = enemyShell.GetComponent<Rigidbody>();

            // forwordはZ軸方向（青軸方向）・・・＞この方向に力を加える
            enemyShellRb.AddForce(transform.forward * shotSpeed);

            AudioSource.PlayClipAtPoint(shotSound, transform.position);

            Destroy(enemyShell, 3.0f);
        }
    }
}
