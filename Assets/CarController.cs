using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{

    float speed = 0;
    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("CarController start.");   
    }

    // Update is called once per frame
    void Update()
    {
        // マウスがクリックされたら
        if (Input.GetMouseButtonDown(0))
        {
            // マウスをクリックした座標
            this.startPos = Input.mousePosition;
            Debug.Log("Start Position = " + startPos);
        } else if (Input.GetMouseButtonUp(0)) {

            Vector2 endPos = Input.mousePosition;
            Debug.Log("End Position = " + endPos);

            float swipeLength = endPos.x - this.startPos.x;
            Debug.Log("Swipe Length = " + swipeLength);
            
            // スワイプの長さを初速度に変換する
            this.speed = swipeLength / 500.0f;

            // 効果音再生（追加）
            GetComponent<AudioSource>().Play();
        }

        // 移動
        transform.Translate(this.speed, 0, 0);
        // 減速
        this.speed *= 0.98f;
    }
}
