using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whaleMove : MonoBehaviour
{
    float PositionData;
    void Update()
    {
        GameObject Camera = GameObject.Find("Camera");
        if (Camera.transform.position.y > this.transform.position.y)
        {
            this.transform.position = new Vector3(this.transform.position.x, Camera.transform.position.y, this.transform.position.z);
        }
        this.transform.Translate(0.05f, 0, 0);
    }
}
