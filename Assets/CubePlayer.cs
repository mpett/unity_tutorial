using UnityEngine;
using System.Collections;

public class CubePlayer : MonoBehaviour {

	public float speed = 6;
	Rigidbody rigidBody;
	Vector3 velocity;
	int coinCount;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody> ();
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 input = new Vector3 (Input.GetAxisRaw ("Horizontal"), 0, Input.GetAxisRaw ("Vertical"));
		Vector3 direction = input.normalized;
		velocity = direction * speed;
	}

	void FixedUpdate () {
		rigidBody.position += velocity * Time.fixedDeltaTime;
	}

	void OnTriggerEnter (Collider triggerCollider) {
		print (triggerCollider.gameObject.name);

		if (triggerCollider.tag == "Coin") {
			Destroy (triggerCollider.gameObject);
			coinCount++;
		}
	}
		
}
