using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
	public float maxHealth = 100f;
	public float curHealth = 0f;
	public GameObject healthBar;
	// Use this for initialization
	void Start () {
		curHealth = maxHealth;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void decresehealth(){
		curHealth -= 0.02f;
		float calcHealth = curHealth / maxHealth * 0.5f;
		SetHealthBar (calcHealth);
	}

	public void SetHealthBar(float myHealth){
		healthBar.transform.localScale = new Vector3 (myHealth, healthBar.transform.localScale.y, healthBar.transform.localScale.z);
	}

}
