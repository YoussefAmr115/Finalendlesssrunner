using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectgeneh : MonoBehaviour
{
    [SerializeField] AudioSource GenehFX;

    void OnTriggerEnter(Collider other)
    {
        GenehFX.Play();
        MasterInfo.GenehCount += 1;
        this.gameObject.SetActive(false);
    }

}
