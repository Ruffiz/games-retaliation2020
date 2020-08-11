using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minimap : MonoBehaviour {

    public Transform Player;
	
	// Dette skjer etter at spilleren har beveget seg
	void LateUpdate () {

        Vector3 newPos = Player.position;
        newPos.y = transform.position.y;
        transform.position = newPos;

        transform.rotation = Quaternion.Euler(90f, Player.eulerAngles.y, 0f);

	}
}
