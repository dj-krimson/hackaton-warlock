using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class P1Health : MonoBehaviour {
	Health HP = new Health();
	//float currentHP1 = HP.GetP1Health();
	//float currentHP2 = Health.GetP2Health();
	private void adjustHealth(float hp){
	//	float health = hp1.getP1Health() + hp;
		gameObject.transform.localScale = new Vector3 (hp, 1F, 1F);
	}
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		adjustHealth (-30F);
		//gameObject.transform.localScale = new Vector3 (0.5F, 1F, 1F);
	}
}
