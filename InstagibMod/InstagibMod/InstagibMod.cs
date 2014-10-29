//Copyright PlazSoft 2014
//Example mod that causes all damage to instantly destroy objects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yargis;

namespace InstagibMod
{
    class InstagibMod : YargisMod, ISessionMod
    {
        public override string Name
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
            //PositiveInfinity is a special case that causes
            //damage to destroy the object.
            Global.Session.Level._Rules.DamageRatio = float.PositiveInfinity;
        }

        public void SessionStartRound()
        {

        }

        public void SessionUpdate()
        {

        }
    }
}
