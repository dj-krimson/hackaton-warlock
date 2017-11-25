using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour {
	static float moveSpeed = 0.1F;
	public float x;
	public float y;
	private GameObject platform;
	Animator anim;

	PlayerHealth ph;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
		ph = GetComponent<PlayerHealth> ();
        platform = GameObject.FindGameObjectWithTag("platform");
		x = platform.transform.localPosition.x;
		y = platform.transform.localPosition.z;
	}
	public void GetInput(float x, float y, float z){
		gameObject.transform.localPosition = new Vector3 (gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z + z);

	}

	
	// Update is called once per frame
	void Update () {
			//gameObject.transform.localRotation = new Vector3 (gameObject.transform.localRotation.x, gameObject.transform.localRotation.y, gameObject.transform.localRotation.z + move);
		if (Input.GetKey (KeyCode.D)) {
			anim.SetInteger ("State", 1);
			gameObject.transform.localPosition = new Vector3 (gameObject.transform.localPosition.x + moveSpeed, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
			gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 90F, gameObject.transform.localEulerAngles.z);
		}
		if (Input.GetKey (KeyCode.A)) {
			anim.SetInteger ("State", 1);
			gameObject.transform.localPosition = new Vector3 (gameObject.transform.localPosition.x - moveSpeed, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z);
			gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 260F, gameObject.transform.localEulerAngles.z);
		}

		if (Input.GetKey (KeyCode.W)) {
			anim.SetInteger ("State", 1);
			gameObject.transform.localPosition = new Vector3 (gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z + moveSpeed);
			if (Input.GetKey (KeyCode.D)) {
				gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 45F, gameObject.transform.localEulerAngles.z);
			} else if (Input.GetKey (KeyCode.A)) {
				gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 260F, gameObject.transform.localEulerAngles.z);
			} else {
				gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 0F, gameObject.transform.localEulerAngles.z);
			}
		}
		if (Input.GetKey (KeyCode.S)) {
			anim.SetInteger ("State", 1);
			gameObject.transform.localPosition = new Vector3 (gameObject.transform.localPosition.x, gameObject.transform.localPosition.y, gameObject.transform.localPosition.z - moveSpeed);
			if (Input.GetKey (KeyCode.D)) {
				gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 135F, gameObject.transform.localEulerAngles.z);
			}else if (Input.GetKey (KeyCode.A)) {
				gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 225F, gameObject.transform.localEulerAngles.z);
			}else {
				gameObject.transform.localEulerAngles = new Vector3 (gameObject.transform.localEulerAngles.x, 180F, gameObject.transform.localEulerAngles.z);
			}
		} 
        
		if(!platform.GetComponent<BoxCollider>().bounds.Contains(gameObject.transform.position)){
			ph.decreaseHealth ();
		}
		
	}
}
