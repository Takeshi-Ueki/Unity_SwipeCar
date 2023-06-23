using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{

    GameObject car;
    GameObject flag;
    GameObject distance;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Game Director start.");
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("Distance");
    }

    // Update is called once per frame
    void Update()
    {
        float length = this.flag.transform.position.x
            - this.car.transform.position.x;

        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text
                = "ÉSÅ[ÉãÇ‹Ç≈" + length.ToString("F2") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text
                = "Game Over.";
        }
    }
}
