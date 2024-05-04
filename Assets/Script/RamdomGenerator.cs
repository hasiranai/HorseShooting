using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamdomGenerator : MonoBehaviour
{
    public int maxValue;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            int ramdomValue = Random.Range(0, maxValue);

            Debug.Log(ramdomValue);

            Debug.Log((float)ramdomValue / 100);
        }
    }
}
