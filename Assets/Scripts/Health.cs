using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Health : MonoBehaviour {
	private float P1Health = 100;
	private float P2Health = 100;
	public float getP1Health(){ return P1Health;}
	public float getP2Health(){ return P2Health;}
	public void setP1Health(float hp){ P1Health = hp; return;}
	public void setP2Health(float hp){ P1Health = hp; return;}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
