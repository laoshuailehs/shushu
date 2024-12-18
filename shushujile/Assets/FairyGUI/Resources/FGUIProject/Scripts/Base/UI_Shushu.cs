/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Base
{
    public partial class UI_Shushu : GComponent
    {
        public GButton m_btn;
        public Transition m_tran1;
        public const string URL = "ui://9179p8wsol3l0";

        public static UI_Shushu CreateInstance()
        {
            return (UI_Shushu)UIPackage.CreateObject("Base", "Shushu");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_btn = (GButton)GetChildAt(3);
            m_tran1 = GetTransitionAt(0);
        }
    }
}