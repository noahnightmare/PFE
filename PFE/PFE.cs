using Exiled.API.Features;
using Player = Exiled.Events.Handlers.Player;
using PlayerRoles.Spectating;
using System;
using Exiled.Events.Handlers;
using PFE;

namespace PFE
{
    public class PFE : Plugin<Config>
    {
        public override string Author => "noahxo";
        public override string Name => "PFE";
        public override string Prefix => Name;

        public static PFE Instance;

        public EventHandlers _handlers;

        public override void OnEnabled()
        {
            Instance = this;

            RegisterEvents();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Instance = null;

            UnregisterEvents();

            base.OnDisabled();
        }
        private void RegisterEvents()
        {
            _handlers = new EventHandlers();

            Player.ChangingRole += _handlers.OnChangingRole;
        }

        private void UnregisterEvents()
        {
            Player.ChangingRole -= _handlers.OnChangingRole;

            _handlers = null;
        }
    }
}
