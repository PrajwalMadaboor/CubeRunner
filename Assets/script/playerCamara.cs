using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCamara : MonoBehaviour
{
    public Transform playertransform;
    public float offset;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraPos = transform.position;
        cameraPos.z = playertransform.position.z + offset;
        transform.position = cameraPos;
    }
}
