//Copyright PlazSoft 2014
//Example mod that causes all damage to instantly destroy objects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yargis;

namespace InstagibMod
{
    public class InstagibMod : ISessionMod
    {
        public string Name
        {
            get { return "Instagib"; }
        }

        public void SessionDraw()
        {

        }

        public void SessionEnd()
        {

        }

        public void SessionEndRound()
        {

        }

        public void SessionStart()
        {
            //Make all damage deal maximum damage
            Global.Session.Level._Rules.DamageRatio = float.MaxValue;
        }

        public void SessionStartRound()
        {

        }

        public void SessionUpdate()
        {

        }
    }
}
