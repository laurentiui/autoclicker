using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class StateDTO
    {
        public ComponentDto Gems1 { get; set; }

        public PositionDto Gems { get; set; } = new PositionDto();
        public PositionDto Damage { get; set; } = new PositionDto();
        public PositionDto Health => Damage;
        public PositionDto TabAttack { get; set; } = new PositionDto();
        public PositionDto TabDefence { get; set; } = new PositionDto();

    }

    internal class PositionDto
    {
        public int X { get; set; }
        public int Y { get; set; }
    }

    internal class ComponentDto
    {
        public string Title { get; set; }
        public int PositionX { get; set; }
        public int PositionY { get; set; }
        //public int ClicksCurrent { get; set; }
        public int ClicksTotal { get; set; }
    }
}
