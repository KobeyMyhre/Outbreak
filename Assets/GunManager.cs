using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour {

    Gun currentGun;
    PlayerController controller;
	// Use this for initialization
	void Start () {
        controller = GetComponent<PlayerController>();
        currentGun = GetComponent<Gun>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        currentGun.shoot(controller);
	}
}
