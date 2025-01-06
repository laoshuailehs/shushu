using System;
using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using Hall;
using UnityEngine;

public class HallPanelUI : MonoBehaviour
{
    private UI_HallMain uiHall;

    private void Awake()
    {
        Application.targetFrameRate = 60;
        UIPackage.AddPackage("FGUIProject/FGUIui/Hall");
        GRoot.inst.SetContentScaleFactor(1334,750);
        HallBinder.BindAll();
    }

    void Start()
    {
        uiHall = UI_HallMain.CreateInstance();
        GRoot.inst.AddChild(uiHall);
    }

    void Update()
    {
        
    }
}
