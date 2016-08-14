using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	// Update is called once per frame
	void Update () {
		Debug.Log("Horizontal Input = "+ Input.GetAxis("Horizontal"));
	}
}
