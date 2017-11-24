using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnerArea : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.localScale = new Vector3 (gameObject.transform.localScale.x * 0.9999F, gameObject.transform.localScale.y, gameObject.transform.localScale.z * 0.9999F);
	}
}
