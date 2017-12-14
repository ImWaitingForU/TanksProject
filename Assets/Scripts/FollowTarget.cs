using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 相机视野跟随坦克移动
/// </summary>
public class FollowTarget : MonoBehaviour {

    public Transform tank1;
    public Transform tank2;
    private Camera camera;

    private Vector3 offset;

	// Use this for initialization
	void Start () {
        offset = transform.position - (tank1.position + tank2.position) / 2;
        camera = this.GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
        if (tank1 == null || tank2 == null) return;
        transform.position = (tank1.position + tank2.position) / 2 + offset;
        if (camera.orthographicSize <= 6.9) return;
        //动态调整视野大小
        float distance = Vector3.Distance(tank1.position,tank2.position);
        float size = distance * 0.48f;
        camera.orthographicSize = size;
    }
}
