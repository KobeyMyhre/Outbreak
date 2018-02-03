using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetDummy : MonoBehaviour, IDamageable {


    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void TurnWhite()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }

    public void takeDamage(float damage)
    {
        Debug.Log("Dame");
        GetComponent<Renderer>().material.color = Color.red;
        Invoke("TurnWhite", .2f);
    }
    public void die()
    {

    }

}
