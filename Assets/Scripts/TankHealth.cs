using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// 控制坦克血量
/// </summary>
public class TankHealth : MonoBehaviour {

    /// <summary>
    /// 初始血量
    /// </summary>
    public int hp = 100;

    /// <summary>
    /// 死亡效果
    /// </summary>
    public GameObject deathAnim;

    /// <summary>
    /// 爆炸音效
    /// </summary>
    public AudioClip deathAudio;

    /// <summary>
    /// 血条
    /// </summary>
    public Slider hpSlider;

    private int hpTotal;

	// Use this for initialization
	void Start () {
        hpTotal = hp;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    //坦克被击中
    void TankHurt()
    {
        if (hp<=0)
        {
            return;
        }
        hp -= Random.Range(10,20);
        hpSlider.value = (float)hp / hpTotal;
        if (hp<=0) 
        {
            AudioSource.PlayClipAtPoint(deathAudio,transform.position);
            GameObject.Instantiate(deathAnim,transform.position+Vector3.up,transform.rotation);
            GameObject.Destroy(this.gameObject);
        }
    }
}
