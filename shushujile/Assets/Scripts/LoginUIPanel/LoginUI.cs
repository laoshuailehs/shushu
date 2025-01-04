using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;
using Login;

public class LoginUI : MonoBehaviour
{
    private UI_LoginMain ui;
    private UI_Loding uiLoding;

    private void Awake()
    {
        LoginBinder.BindAll();
        UIPackage.AddPackage("FGUIProject/FGUIui/Login");
        GRoot.inst.SetContentScaleFactor(1334,750);
    }

    void Start()
    {
        ui = UI_LoginMain.CreateInstance();
        uiLoding = UI_Loding.CreateInstance();
        GRoot.inst.AddChild(ui);
        ui.m_btn_login.onClick.Set(OnLoginClick);
        ui.m_tran_login.SetHook("changefield",playnum);

        uiLoding.m_prossing.value = 0;

    }
    float _value = 0;
    private void Update()
    {
        _value = Time.deltaTime*20f + _value;
        if (_value >= 100)
        {
            _value = 0;
        }
        uiLoding.m_t1.text = $"{(int)_value}/100";
        uiLoding.m_prossing.value = _value;
    }

    private void OnLoginClick()
    {
        Debug.Log("游戏登入");
        ui.m_tran_login.Play(() => { GRoot.inst.AddChild(uiLoding); });
    }

    private void playnum()
    {
        GTween.To(0, 100, 0.3f).SetEase(EaseType.Linear).OnUpdate((GTweener tweener) =>
        {
            ui.m_field1.text = "" + Mathf.Floor(tweener.value.x);
        });
    }
}
