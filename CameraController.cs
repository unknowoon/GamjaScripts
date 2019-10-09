using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject Gamja;
    void Update()
    {
        if (Gamja.transform.position.y > transform.position.y + 5) transform.position = new Vector3(0, Gamja.transform.position.y - 5, -10);
    }
}
