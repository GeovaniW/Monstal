using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MouseShoot : NetworkBehaviour {

	public Vector3 mousePos;
	
	void Start () {
		
	}

	void Update () {
		if (!isLocalPlayer)
			return;

		mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		mousePos.z = 10;
		transform.position = mousePos;
	}
}