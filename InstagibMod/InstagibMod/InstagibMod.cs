//Copyright PlazSoft 2014
//Example mod that causes all damage to instantly destroy objects.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Yargis;

namespace InstagibMod
{
    public class InstagibMod : SessionMod
    {
        public override string Name
        {
            get { return "Instagib"; }
        }
        public override string Description
        {
            get { return "Weapons instantly destroy their targets.";  }
        }

        public override void SessionDraw()
        {

        }

        public override void SessionEnd()
        {

        }

        public override void SessionEndRound()
        {

        }

        public override void SessionStart()
        {
            //Uncomment and change to adjust the damage
            //done by everything in the current game session.
            //Global.Session.Level._Rules.DamageRatio = 1f;
        }

        public override void SessionStartRound()
        {

        }

        public override void SessionUpdate()
        {

        }

        public override void SessionPlayerSpawn(Player p, Entity ship)
        {
            //For each weapon on the ship
            for (int i = 0; i < ship.Objects.Count; i++)
            {
                //Obtain the weapon fire component if one exists.
                var weaponFire = ship.Objects[i].GetComp<Yargis.Components.WeaponFire>();
                if (weaponFire != null)
                {
                    //Retrieve the damage component from the bullet
                    //it fires.
                    var bulletDamage = weaponFire.Bullet.GetComp<Yargis.Components.DamageComponent>();
                    if (bulletDamage != null)
                    {
                        //Make the weapon do maximum damage (only if the
                        // weapon would have done damage.)
                        if (bulletDamage.Value > 0f)
                        { 
                            bulletDamage.Value = float.MaxValue;
                        }
                    }
                }
            }
        }

        public override bool SessionCanConfigure { get { return false; } }
        public override void SessionConfigure() 
        {

        }
    }
}
