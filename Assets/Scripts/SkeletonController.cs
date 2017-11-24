using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkeletonController : MonoBehaviour {
	//Animator anim;	
	public Transform target;
	public float speed = 6.0F;
	private float movingDir = 0;


	// moving-functions
	private float getMovingDir (){
		return movingDir;
	}
	private void setGoalCords(float x, float y){ 
		movingDir = x;
		// beräkna moving dir, beroende på var 
	return;
	}
	

	private void moveChar(float dir){ 
		// rör gubben mot målet
		transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
		return;
	}
	private void setIdle(){
		// sätt gubbens animation till idle
		movingDir=0;
		return;
	}



	void Start () {
		//anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) { 
			// setGoalCords(x,y);
			// räkna ut vilken moveDir
		}
			
		if(true==false){ // sätt idle
			
		}
		else
			moveChar(movingDir);
	}
}
