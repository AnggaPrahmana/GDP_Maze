using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour {
	
	public Text pouch;
	int maxItem = 2;

	[SerializeField]
	int myItem = 0;
	public float speed;
	public Transform flashLight;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		Vector3 direction;
		if(Input.GetKey(KeyCode.UpArrow)){
			//transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z+speed);
			//transform.Translate(0,0,Time.deltaTime);
			direction = flashLight.position-transform.position
			flashLight.transform.localRotation = Quaternion.Euler(0,360,0);
			transform.rotation = Vector3.Slerp(transform.rotation, Quaternion.LookRotation(direction),1f);
		}
		if(Input.GetKey(KeyCode.DownArrow)){
			//transform.position = new Vector3(transform.position.x,transform.position.y,transform.position.z-speed);
			direction = flashLight.position-transform.position
			flashLight.transform.localRotation = Quaternion.Euler(0,180,0);
			transform.rotation = Vector3.Slerp(transform.rotation, Quaternion.LookRotation(direction),1f);
		}
		if(Input.GetKey(KeyCode.LeftArrow)){
			//transform.position = new Vector3(transform.position.x-speed,transform.position.y,transform.position.z);
			direction = flashLight.position-transform.position
			flashLight.transform.localRotation = Quaternion.Euler(0,-90,0);
			transform.rotation = Vector3.Slerp(transform.rotation, Quaternion.LookRotation(direction),1f);
		}
		if(Input.GetKey(KeyCode.RightArrow)){
			//transform.position = new Vector3(transform.position.x+speed,transform.position.y,transform.position.z);
			direction = flashLight.position-transform.position
			flashLight.transform.localRotation = Quaternion.Euler(0,90,0);
			transform.rotation = Vector3.Slerp(transform.rotation, Quaternion.LookRotation(direction),1f);
		}
		

		Physics.Raycast(transform.position,transform.forward,5f);
	}
	void OnCollisionEnter(Collision col){
		if(col.gameObject.tag=="item"){
			myItem += 1;
			pouch.text = myItem.ToString();
			Destroy(col.gameObject);
		}
	}

	public bool isPouchFull(){
		if(myItem < maxItem){
			return false;
		}
		return true;
	}
}
