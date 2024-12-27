using System;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using Exiled.Loader;
using player = Exiled.Events.Handlers.Player;

namespace NoRadioDrain
{
    public class RadioDrain : Plugin<Config>
    {
        public static RadioDrain Instance;
        public override string Author => "HyperBeast";
        public override string Name => "No Radio Drain";
        public override Version Version => new Version(1,0);
        public override Version RequiredExiledVersion => new Version(9, 1, 0);

        public override void OnEnabled()
        {
            Instance = this;
            player.UsingRadioBattery += EventHandlers.UsingRadioPickupBattery.RadioDrain;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Instance = null;
            player.UsingRadioBattery -= EventHandlers.UsingRadioPickupBattery.RadioDrain;
            base.OnDisabled();
        }
    }
}
