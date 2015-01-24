using UnityEngine;
using System.Collections;

public class Teleport : MonoBehaviour {

	public GameObject target;
	public float adjustTarget;
	bool jump;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (!jump) {
			if (other.gameObject.tag == "Player") {
					target.GetComponent<Teleport>().jump = true;
					other.gameObject.transform.position = new Vector3 (target.transform.position.x, 
			                                                   			target.transform.position.y + adjustTarget, 0);
					}
				}
		}

	void OnTriggerExit2D(Collider2D other) {
		if(other.tag == "Player") {
			jump = false;
		}
	}
}
