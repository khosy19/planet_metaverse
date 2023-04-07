using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rerotation : MonoBehaviour
{
    public Vector3 newRotation;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(newRotation * Time.deltaTime);
    }
}
