using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {

	[SerializeField]
	Transform pos_1, pos_2;

	int target =1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target==1){
			transform.position =  Vector3.MoveTowards(transform.position,pos_1.position,2f*Time.deltaTime);
		}
		else if(target==2){
			transform.position =  Vector3.MoveTowards(transform.position,pos_2.position,2f*Time.deltaTime);
		}
	}

	void OnTriggerEnter(Collider col){
		if(col.transform.gameObject.name=="pos1"){
			target = 2;
		}
		else if(col.transform.gameObject.name=="pos2"){
			target = 1;
		}
	}
}
