using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer)
			return;

		if(Input.GetKey(KeyCode.A))
		{
			transform.Translate(Vector3.left * Time.deltaTime);
		}

		if(Input.GetKey(KeyCode.D))
		{
			transform.Translate(Vector3.right * Time.deltaTime);
		}
	}
}
