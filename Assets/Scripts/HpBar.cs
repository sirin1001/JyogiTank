using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    Slider slider;
    RectTransform rt;
    GameObject player;

    void Start()
    {
        slider = this.GetComponent<Slider>();
        rt = this.GetComponent<RectTransform>();
        player = GameObject.Find("Player");
    }

    void Update()
    {
        var pos = player.transform.position;
        rt.anchoredPosition = pos;
        
    }
}
