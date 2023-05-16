using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HpBar : MonoBehaviour
{
    Slider slider;
    RectTransform rt;
    GameObject player;
    Vector3 targetPos;
    Vector2 screenPos;
    Vector2 localRect;

    void Start()
    {
        slider = this.GetComponent<Slider>();
        rt = this.GetComponent<RectTransform>();
        player = GameObject.Find("Player");

    }

    void Update()
    {
        FollowPlayerHPBar();
    }

    void FollowPlayerHPBar()
    {
        targetPos = player.transform.position;
        targetPos.y += 2;
        screenPos = Camera.main.WorldToScreenPoint(targetPos);

        RectTransform parentUI = rt.parent.GetComponent<RectTransform>();
        RectTransformUtility.ScreenPointToLocalPointInRectangle(parentUI, screenPos, Camera.main, out localRect);

        rt.anchoredPosition = localRect;
    }

    public void UpdateHPValue()
    {
        float HPValue = GameObject.Find("Player").GetComponent<Status>().HP;
        slider.value = HPValue;
    }
}
