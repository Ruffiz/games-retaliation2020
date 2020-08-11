using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spotLightControl : MonoBehaviour {

    public Transform camTarget;
    public float xDistance, yDistance, zDistance;

    void Start()
    {

    }

    void Update()
    {
        transform.position = new Vector3(camTarget.position.x + xDistance, camTarget.position.y + yDistance, camTarget.position.z + zDistance);
    }
}
