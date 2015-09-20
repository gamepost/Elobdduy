using System.Drawing;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;

namespace PingBuddy
{
    internal class Program
    {
        public static Menu Config;

        private static void Main(string[] args)
        {
            Config = MainMenu.AddSubMenu("Game Ping", "PingBuddy");
            Config.Add("Show", new CheckBox("Show Game Ping"));
 
            Drawing.OnDraw += (arg) =>
            {
                if (Config["Show"].Cast<Checkbox>().CurrentValue)
                    Drawing.DrawText(Drawing.Width*0.94f, Drawing.Height*0.05f, Color.GreenYellow, "Ping: " + Game.Ping);
            };
        }
    }
}
