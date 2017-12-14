using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellExplosionDestroy : MonoBehaviour {
      
    /// <summary>
    /// 动画持续时间
    /// </summary>
    public float anim_time;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        GameObject.Destroy(this.gameObject,anim_time);
	}
}
