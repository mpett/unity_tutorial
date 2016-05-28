using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	public Transform sphereTransform;

	// Use this for initialization
	void Start () {
		sphereTransform.parent = transform;
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate (Vector3.up * Time.deltaTime * 180);
	}
}
