using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPItem : MonoBehaviour
{
    //public GameObject effectPrefab;
    public AudioClip getSound;

    private HorseHealth hh;
    private int reward = 3;  // いくつ回復させるか

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hh = GameObject.Find("Horse").GetComponent<HorseHealth>();

            hh.AddHP(reward);

            Destroy(gameObject);
            //GameObject effect = Instantiate(effectPrefab, transform.position, Quaternion.identity);
            //Destroy(effect, 0.5f);
            AudioSource.PlayClipAtPoint(getSound, transform.position);
        }
    }
}
