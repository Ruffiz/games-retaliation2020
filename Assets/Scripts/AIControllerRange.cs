using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIControllerRange : MonoBehaviour {

    Transform player;
    public GameObject zombieOne;

    void Awake()
    {
        player = GameObject.FindWithTag("MainCharacter").transform;
    }
}
