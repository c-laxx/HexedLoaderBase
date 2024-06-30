using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using WorldAPI.ButtonAPI.Groups;
using WorldAPI.ButtonAPI;

namespace HexedBase
{
    internal class Main
    {
        public static VRCPage MainPage;
        public static VRCPage TargetPage;
        public static ButtonGroup MainGrp;
        public static ButtonGroup TargetGrp;

        internal static void Init()
        {
            MainPage = new VRCPage("", true, true, false, null, "", null, false, true);
            TargetPage = new VRCPage("", false, true, false, null, "", null, false, true);

            MainGrp = new ButtonGroup(MainPage, "", false);
            TargetGrp = new ButtonGroup(TargetPage, "Targets", false);

            new Tab(MainPage, "", null);
            MainGrp.AddButton("example", "example", () => { }, false, false);



        }
    }
}
