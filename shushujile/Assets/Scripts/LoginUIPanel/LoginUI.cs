using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using FairyGUI;

public class LoginUI : MonoBehaviour
{
    private GButton btn_login;
    private GComponent _component;
    void Start()
    {
        GRoot.inst.SetContentScaleFactor(1334,750);
        UIPackage.AddPackage("FGUIProject/FGUIui/Login");
        _component = UIPackage.CreateObject("Login", "LoginMain").asCom;
        _component.GetTransition("tran_login").SetHook("changefield",playnum);
        GRoot.inst.AddChild(_component);
        btn_login= _component.GetChild("btn_login").asButton;
        btn_login.onClick.Set(OnLoginClick);
    }

    private void OnLoginClick()
    {
        Debug.Log("游戏登入");
        var t1 = _component.GetTransition("tran_login");
        t1.Play();
    }

    private void playnum()
    {
        GTween.To(0, 100, 0.3f).SetEase(EaseType.Linear).OnUpdate((GTweener tweener) =>
        {
            _component.GetChild("field1").text = "" + Mathf.Floor(tweener.value.x);
        });
    }
}
