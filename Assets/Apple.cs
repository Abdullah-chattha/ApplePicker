using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Apple : MonoBehaviour {
	[Header("Set in Inspector")]
	public static float bottomY = -20f;

	void Update () {
		if ( transform.position.y < bottomY ) {
			Destroy( this.gameObject );
			// Get a reference to the ApplePicker component of Main Camera
			ApplePicker apScript = Camera.main.GetComponent<ApplePicker>(); // b
			// Call the public AppleDestroyed() method of apScript
			apScript.AppleDestroyed() ;
		}
	}
}