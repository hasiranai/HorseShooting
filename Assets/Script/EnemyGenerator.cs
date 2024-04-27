using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public DestroyObject[] EnemyPlefabs;
    public float waitTime;
    public int maxCount;
    private float timer;
    private int GenerateCount;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        if (GenerateCount >= maxCount)
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer >= waitTime)
        {
            timer = 0;

            //敵を作る
            Generate();
        }
    }

    private void Generate()
    {
        // ランダムな配列を決める
        int ramdomIndex = Random.Range(0, EnemyPlefabs.Length);

        // 敵を生成
        Instantiate(EnemyPlefabs[ramdomIndex], transform.position, Quaternion.identity);

        GenerateCount++;
    }
}
