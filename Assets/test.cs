using UnityEngine;
using System.Collections;

public class test : MonoBehaviour {

	int frameCount = 0;

	// Use this for initialization
	void Start () {
		print ("Start");
		float distance = getDistanceBetweenPoints (0, 5, 10, 15);
		print (distance);
	
	}
	
	// Update is called once per frame
	void Update () {
		frameCount += 1;
		// print ("Frame count " + frameCount);
	}

	float getDistanceBetweenPoints(float x1, float y1, float x2, float y2) {
		float dX = x2 - x1;
		float dY = y2 - y1;
		float distanceSquared = dX * dX + dY * dY;
		float distance = Mathf.Sqrt (distanceSquared);
		return distance;
	}


}
