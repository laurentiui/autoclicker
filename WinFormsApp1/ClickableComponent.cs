using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    internal class ClickableComponent
    {
        public string Title;

        protected TextBox txtPositionX;
        protected TextBox txtPositionY;
        protected Label lblCurrent;
        protected Label lblTotal;

        private int currentClicks;
        private int totalClicks;

        private CustomMouseClick clicker;

        public ClickableComponent(string title, TextBox txtPositionX, TextBox txtPositionY, Label lblCurrent, Label lblTotal)
        {
            this.Title = title;
            this.txtPositionX = txtPositionX;
            this.txtPositionY = txtPositionY;
            this.lblCurrent = lblCurrent;
            this.lblTotal = lblTotal;

            clicker = new CustomMouseClick();
        }

        public void SaveData(Point point)
        {
            txtPositionX.Text = point.X.ToString();
            txtPositionY.Text = point.Y.ToString();

        }

        public void LoadData(ComponentDto componentDto) {
            txtPositionX.Text = $"{componentDto.PositionX}";
            txtPositionY.Text = $"{componentDto.PositionY}";
            //lblCurrent.Text = $"{componentDto.ClicksCurrent}";
            lblCurrent.Text = $"0";
            lblTotal.Text = $"{componentDto.ClicksTotal}";

            totalClicks = componentDto.ClicksTotal;
        }

        public ComponentDto GetData()
        {
            ComponentDto componentDto = new ComponentDto()
            {
                Title = Title,
                PositionX = int.Parse(txtPositionX.Text),
                PositionY = int.Parse(txtPositionY.Text),
                //ClicksCurrent = int.Parse(lblCurrent.Text),
                ClicksTotal = int.Parse(lblTotal.Text)
            };

            return componentDto;
        }

        public void Click()
        {
            currentClicks++;
            totalClicks++;

            lblCurrent.Text = $"{currentClicks}";
            lblTotal.Text = $"{totalClicks}";

            //clicker.ClickAt(int.Parse(txtPositionX.Text), int.Parse(txtPositionY.Text));
        }

    }
}
