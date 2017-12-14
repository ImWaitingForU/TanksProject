using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankFire : MonoBehaviour {

    public GameObject shellPrefab;
    public KeyCode fireKey = KeyCode.Space;
    private Transform firePosition;

    public float shellSpeed = 15;//子弹速度
    public AudioClip fireAudio;

	// Use this for initialization
	void Start () {
        firePosition = transform.Find("FirePosition");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(fireKey))
        {
            AudioSource.PlayClipAtPoint(fireAudio, transform.position);
            GameObject go = GameObject.Instantiate(shellPrefab,firePosition.position,firePosition.rotation) as GameObject;
            go.GetComponent<Rigidbody>().velocity = go.transform.forward * shellSpeed;
        }
	}
}
