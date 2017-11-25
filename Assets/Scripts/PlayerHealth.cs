using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float maxHealth = 100f;
	public float curHealth;
	public GameObject healthBar;
	// Use this for initialization
	void Start () {
		curHealth = maxHealth-10F;
	}
	
	// Update is called once per frame
	void Update () {
		//decreaseHealth ();
	}

	public void decreaseHealth(){
		curHealth -= 0.02f;
		float calcHealth = curHealth / maxHealth * 0.5f;
		SetHealthBar (calcHealth);
	}

	public void SetHealthBar(float myHealth){
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

}
