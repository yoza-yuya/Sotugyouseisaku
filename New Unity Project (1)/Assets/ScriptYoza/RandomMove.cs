using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomMove : MonoBehaviour
{
    public float speed = 3.5f;
    private float chargeTime = 5.0f;
    private float timeCount;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        timeCount += Time.deltaTime;


        // 指定時間の経過（条件）
        if (timeCount > chargeTime)
        {
            // 進路をランダムに変更する
            Vector3 course = new Vector3(0, Random.Range(0, 180), 0);
            transform.localRotation = Quaternion.Euler(course);

            // タイムカウントを０に戻す
            timeCount = 0;
        }
    }
    void FixedUpdate()
    {
        rb.MovePosition(transform.position + transform.forward * speed * Time.deltaTime);
    }
}
