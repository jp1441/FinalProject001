using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn1 : MonoBehaviour {
	public float threshold;
	
	void FixedUpdate() {
		if (transform.position.y < threshold)
			transform.position = new Vector3(1, 2, 7);
	}
}