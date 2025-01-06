/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Hall
{
    public partial class UI_HallMain : GComponent
    {
        public GLoader m_avator;
        public GTextField m_playername;
        public GTextField m_level;
        public GProgressBar m_exp;
        public GGraph m_bg_uselu;
        public GLoader m_player;
        public const string URL = "ui://1yy752bry7hr0";

        public static UI_HallMain CreateInstance()
        {
            return (UI_HallMain)UIPackage.CreateObject("Hall", "HallMain");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_avator = (GLoader)GetChildAt(2);
            m_playername = (GTextField)GetChildAt(3);
            m_level = (GTextField)GetChildAt(5);
            m_exp = (GProgressBar)GetChildAt(6);
            m_bg_uselu = (GGraph)GetChildAt(8);
            m_player = (GLoader)GetChildAt(9);
        }
    }
}