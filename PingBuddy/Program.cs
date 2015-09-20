#region
using System.Drawing;
using EloBuddy;
using EloBuddy.SDK;
using EloBuddy.SDK.Enumerations;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
#endregion

namespace PingBuddy
{
    internal class Program
    {
        public static Menu Config;

        private static void Main(string[] args)
        {
            Config = new Menu("Game Ping", "PingBuddy", true);
            Config.AddItem(new MenuItem("Show", "Show Game Ping").SetValue(true));
            Config.AddToMainMenu();
 
            Drawing.OnDraw += (arg) =>
            {
                if (Config.Item("Show").IsActive())
                    Drawing.DrawText(Drawing.Width*0.94f, Drawing.Height*0.05f, Color.GreenYellow, "Ping: " + Game.Ping);
            };
        }
    }
}
