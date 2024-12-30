/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_LoginMain : GComponent
    {
        public GLoader m_bg;
        public GButton m_btn_login;
        public GLoader m_bg1;
        public GTextField m_field1;
        public Transition m_tran_login;
        public const string URL = "ui://tzpmlwovegb00";

        public static UI_LoginMain CreateInstance()
        {
            return (UI_LoginMain)UIPackage.CreateObject("Login", "LoginMain");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_bg = (GLoader)GetChildAt(0);
            m_btn_login = (GButton)GetChildAt(1);
            m_bg1 = (GLoader)GetChildAt(2);
            m_field1 = (GTextField)GetChildAt(5);
            m_tran_login = GetTransitionAt(0);
        }
    }
}