using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterInfo : MonoBehaviour
{
    public static int GenehCount = 0;
    [SerializeField] GameObject GenehDisplay;

    void Update()
    {
        GenehDisplay.GetComponent<TMPro.TMP_Text>().text = "Geneh: " + GenehCount;
    }
}
