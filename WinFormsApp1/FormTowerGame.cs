using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class FormTowerGame : Form
    {
        private StateDTO dto = new StateDTO();
        private EnumPositions pickLocation;
        private GameState gameState;
        //private CustomMouseClick clicker;

        private int clickCounter = 0;

        private ClickableComponent gemsComponent;
        private ClickableComponent damageComponent;

        public FormTowerGame()
        {
            InitializeComponent();

            pickLocation = EnumPositions.None;

            gemsComponent = new ClickableComponent("Gems", 
                txtPositionGemsX, txtPositionGemsY, lblIterationCurrentGems, btnIterationTotalGems);
            damageComponent = new ClickableComponent("Damage",
                txtPositionDamageX, txtPositionDamageY, lblIterationCurrentDamage, btnIterationTotalDamage);
            timerClicks.Interval = 1000;

            //clicker = new CustomMouseClick();

            gameState = new GameState(new List<ClickableComponent>() { 
                gemsComponent,
                damageComponent
            });
            gameState.Load();

        }

        private void FormTowerGame_Deactivate(object sender, EventArgs e)
        {
            var pos = Cursor.Position;
            Log($"{pickLocation} location: {pos.X} / {pos.Y}");

            switch (pickLocation)
            {
                case EnumPositions.Gems:
                    gemsComponent.SaveData(pos);
                    gameState.Save();
                    break;
                case EnumPositions.Damage:
                    damageComponent.SaveData(pos);
                    gameState.Save();
                    break;
                default:
                    Log($"No location pick");
                    break;
            }

            pickLocation = EnumPositions.None;

            btnLocationGems.Enabled = true;
            btnLocationDamage.Enabled = true;


        }

        private async Task Log(string message)
        {
            txtLog.AppendText($"{DateTime.Now.ToString("HH:mm:ss")}: {message} {Environment.NewLine}");
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                lblCounterSteps.Text = "0 / 12";

                Log("Start clicker");
                timerClicks.Start();
                clickCounter = 0;

            }
            else
            {
                btnStartStop.Text = "Start";

                Log("Stop clicker");
                timerClicks.Stop();
            }
        }


        private void btnLocationGems_Click(object sender, EventArgs e)
        {
            pickLocation = EnumPositions.Gems;
            btnLocationGems.Enabled = false;
        }

        private void btnLocationDamage_Click(object sender, EventArgs e)
        {
            pickLocation = EnumPositions.Damage;
            btnLocationDamage.Enabled = false;
        }

        private void timerClicks_Tick(object sender, EventArgs e)
        {
            clickCounter++;
            lblCounterSteps.Text = $"{clickCounter} / 12";
            //Log($"I AM CLICK {clickCounter}");

            switch (clickCounter)
            {
                case 1:
                    //gemsComponent
                    Log("Click gems");
                    gemsComponent.Click();
                    gameState.Save();
                    //int currentGems = int.Parse(lblIterationCurrentGems.Text);
                    //currentGems++;
                    //lblIterationCurrentGems.Text = $"{currentGems}";
                    //clicker.ClickAt(int.Parse(txtPositionGemsX.Text), int.Parse(txtPositionGemsY.Text));
                    break;
                case 2:
                    Log("Click Damage");
                    int currentDamage = int.Parse(lblIterationCurrentDamage.Text);
                    currentDamage++;
                    lblIterationCurrentDamage.Text = $"{currentDamage}";
                    //clicker.ClickAt(int.Parse(txtPositionDamageX.Text), int.Parse(txtPositionDamageY.Text));
                    break;
                default:
                    //Log("")
                    break;

            }

            if (clickCounter >= 12)
            {
                clickCounter = 0;
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //timerClicks.pas
        }
    }
}
