using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Back_To_The_Future_Game
{
    public class Hoverboard : GameObject, IHover
    {
        public override int GameObjectID { get; set; }

        public override string Name { get; set; }

        public override string Description { get; set; }

        public override int YearTimeLocationID { get; set; }

        public override bool HasValue { get; set; }

        public override int Value { get; set; }

        public override bool CanAddToInventory { get; set; }

        public bool AboveWater { get; set; }

        public int BatteryPower { get; set; }

        public HoverAction GetHoverAction()
        {
            HoverAction hoverAction = HoverAction.None;
            BatteryPower = 95;
            Random random = new Random();

            if (random.Next(1, 100) > BatteryPower  )
            {
                hoverAction = HoverAction.Hover;
            }
            else if (random.Next(1, 100) > BatteryPower)
            {
                hoverAction = HoverAction.Cruise;
            }
            else if (random.Next(1, 100) < BatteryPower)
            {
                hoverAction = HoverAction.Speed;
            }
            
           

            return hoverAction;
        }
    }
}
