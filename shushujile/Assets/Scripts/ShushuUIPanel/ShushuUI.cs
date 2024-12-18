using System;
using System.Collections;
using System.Collections.Generic;
using Base;
using UnityEngine;
using FairyGUI;

public class ShushuUI : MonoBehaviour
{
    private void Awake()
    {
        
    }

    private void Start()
    {
        GRoot.inst.SetContentScaleFactor(800, 600);  //初始化设置合适的比例（分辨率也就设置好了）
        UIPackage.AddPackage("FGUIProject/FGUIui/Base");  //加载打包好的项目
        GComponent component = UIPackage.CreateObject("Base", "Shushu").asCom;
        // 加载对应的组件   通过.asCom（或as GComponent）类型转换将它转换为GComponent组件类型
        GRoot.inst.AddChild(component);
    }
}
