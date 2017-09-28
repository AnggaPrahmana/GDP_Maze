using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashScript : MonoBehaviour {

	Light light;
	// Use this for initialization
	void Start () {
		light = GetComponent<Light>();
		StartCoroutine(flash());
	}
	
	IEnumerator flash(){
		while(true){

			yield return new WaitForSeconds(0.1f);
			light.intensity = Random.Range(10,18);
		}
	}
}
