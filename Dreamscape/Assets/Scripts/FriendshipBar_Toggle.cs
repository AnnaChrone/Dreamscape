/*
Title: Unity Tutorial: Open Panel on Button Click
Author: Jayanam
Date: 26 September 2018
Availability: https://youtu.be/LziIlLB2Kt4?si=xGodF8WYXoNp7duv*/
using UnityEngine;

public class Panel_Toggle : MonoBehaviour
{
    public GameObject Panel;

    public void OpenPanel()
    {
        bool isActive = Panel.activeSelf;

        Panel.SetActive(!isActive);
    }
}
