/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using FairyGUI.Utils;

namespace Login
{
    public partial class UI_Loding : GComponent
    {
        public GProgressBar m_prossing;
        public GTextField m_t1;
        public const string URL = "ui://tzpmlwovlerj20";

        public static UI_Loding CreateInstance()
        {
            return (UI_Loding)UIPackage.CreateObject("Login", "Loding");
        }

        public override void ConstructFromXML(XML xml)
        {
            base.ConstructFromXML(xml);

            m_prossing = (GProgressBar)GetChildAt(0);
            m_t1 = (GTextField)GetChildAt(1);
        }
    }
}