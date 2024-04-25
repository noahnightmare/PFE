using Exiled.API.Features.Items;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utf8Json.Internal.DoubleConversion;
using PlayerRoles;
using UnityEngine;
using Exiled.API.Enums;

namespace PFE
{
    public class EventHandlers
    {
        public void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (AutoEvents.AutoEvents.isEventRunning) return;

            if (ev.Player.Role != RoleTypeId.Scp173) return;

            if (ev.Reason != SpawnReason.Died) return;

            for (int i = 0; i < PFE.Instance.Config.Grenades; i++)
            {
                ev.Player.Position += Vector3.up;
                ExplosiveGrenade grenade = (ExplosiveGrenade)Item.Create(ItemType.GrenadeHE);
                grenade.FuseTime = PFE.Instance.Config.FuseTime;
                grenade.SpawnActive(ev.Player.Position, ev.Player);
            }
        }
    }
}
