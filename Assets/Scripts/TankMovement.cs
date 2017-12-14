using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMovement : MonoBehaviour
{

    public float speed = 5;
    public float angularSpeed = 10;
    private Rigidbody rigidbody;

    public AudioClip idleAudio;
    public AudioClip drivingAudio;
    private AudioSource audioSource;

    //判断是player1还是player2
    public float number = 1;

    // Use this for initialization
    void Start()
    {
        rigidbody = this.GetComponent<Rigidbody>();
        audioSource = this.GetComponent<AudioSource>();
    }

    /// <summary>
    /// 固定帧update
    /// </summary>
    private void FixedUpdate()
    {
        //垂直方向移动
        float v = Input.GetAxis("VerticalPlayer" + number);
        rigidbody.velocity = transform.forward * v * speed;
        //转向
        float h = Input.GetAxis("HorizontalPlayer" + number);
        rigidbody.angularVelocity = transform.up * h * angularSpeed;

        //如果产生了移动
        if (Mathf.Abs(h) > 0.1 || Mathf.Abs(v) > 0.1)
        {
            audioSource.clip = drivingAudio;
            if (audioSource.isPlaying == false)
            {
                audioSource.Play();
            }
        }
        else
        {
            audioSource.clip = idleAudio;
            if (audioSource.isPlaying == false)
            {
                audioSource.Play();
            }
        }
    }
}
