using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class Spawn : MonoBehaviour {

    public GameObject enemiePrefab;
    public GameObject newEnemie;
    public GameObject player;
    public float timeInit;
    public float timeToSpawn;

	// Use this for initialization
	void Start () {
        timeToSpawn = timeInit;
	}
	
	// Update is called once per frame
	void Update () {
        timeToSpawn--;
        if (timeToSpawn <= 0)
        {
            newEnemie = (GameObject)Instantiate(enemiePrefab, transform.position, Quaternion.identity);
            NetworkServer.SpawnWithClientAuthority(newEnemie, player);
            timeToSpawn = timeInit;
        }
	}
}
