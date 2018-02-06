using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnockBack : MonoBehaviour {

    PlayerController controller;
    public GameObject hitCollider;
    public bool knockBackCD;
	// Use this for initialization
	void Start ()
    {
        knockBackCD = true;
        hitCollider.SetActive(false);
        controller = GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update ()
    {
		if(controller.knockBackDown && knockBackCD)
        {
            knockBackCD = false;
            hitCollider.SetActive(true);
            StartCoroutine(offCollider());
        }
	}

    IEnumerator offCollider()
    {
        yield return .1f;
        hitCollider.SetActive(false);
        knockBackCD = true;
    }
}
