using System;
using Exiled.Events.EventArgs.Player;

namespace NoRadioDrain.EventHandlers
{
    public static class UsingRadioPickupBattery
    {
        public static void RadioDrain(UsingRadioBatteryEventArgs ev)
        {
            ev.Drain = 0;
        }
    }
}
