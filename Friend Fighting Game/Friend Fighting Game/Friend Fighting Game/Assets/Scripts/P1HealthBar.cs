using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1HealthBar : MonoBehaviour {

    public float TotalHp;
    public float currentHp;

	// Use this for initialization
	void Start () {
        currentHp = TotalHp;
	}
	
	// Update is called once per frame
	void Update () {
      
	}

    public void TakeDamage()
    {
        currentHp -= 5;
        transform.localScale = new Vector3((currentHp / TotalHp), 1, 1);
    }
}
