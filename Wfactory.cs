using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wfactory : MonoBehaviour
{
    public GameObject whaleL;
    public int rNum;

    void Update()
    {
        rNum = Random.Range(0, 10);
        if (rNum == 0)
        {
            GameObject whale = Instantiate(whaleL) as GameObject;

            whale.transform.position = new Vector3(-26, 0, 0);
        }
    }

    void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}