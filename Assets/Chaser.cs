using UnityEngine;
using System.Collections;

public class Chaser : MonoBehaviour {

	public Transform targetTransfrom;
	public float speed = 7;

	void Update() {
		Vector3 displacementFromTarget = targetTransfrom.position - transform.position;
		Vector3 directionToTarget = displacementFromTarget.normalized;
		Vector3 velocity = directionToTarget * speed;

		float distanceToTarget = displacementFromTarget.magnitude;

		if (distanceToTarget > 1.5f) {
			transform.Translate (velocity * Time.deltaTime);	
		}
	}
}
