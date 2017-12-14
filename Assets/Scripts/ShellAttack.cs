using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShellAttack : MonoBehaviour {

    public GameObject shellExplosion;
    public AudioClip shellExplosionAudio;

    private void OnTriggerEnter(Collider other)
    {
        //播放炮弹音效
        AudioSource.PlayClipAtPoint(shellExplosionAudio, transform.position);
        //销毁自身
        GameObject.Destroy(this.gameObject);
        //新建特效
        GameObject.Instantiate(shellExplosion, transform.position, transform.rotation);

        //击中坦克
        if (other.tag == "Tank")
        {
            other.SendMessage("TankHurt");
        }
    }


}
