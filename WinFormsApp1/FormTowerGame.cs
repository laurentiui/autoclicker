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
        private Logger logger;

        private EnumPositions pickLocation;
        private GameState gameState;

        private int clickCounter = 0;
        private int cycleCounter = 0;

        private ClickableComponent gemsComponent;
        private ClickableComponent tabAttackComponent;
        private ClickableComponent damageComponent;
        private ClickableComponent tabDefenceComponent;
        private ClickableComponent healthComponent;
        //private TextBox txtPositionTabDefanceY;

        public FormTowerGame()
        {
            InitializeComponent();
            //timerClicks.Interval = 1000;

            logger = new Logger(txtLog);

            pickLocation = EnumPositions.None;

            gemsComponent = new ClickableComponent("Gems", logger,
                txtPositionGemsX, txtPositionGemsY, lblIterationCurrentGems, btnIterationTotalGems);

            tabAttackComponent = new ClickableComponent("AttackTab", logger,
                txtPositionTabAttackX, txtPositionTabAttackY, lblIterationCurrentTabAttack, btnIterationTotalTabAttack);
            damageComponent = new ClickableComponent("Damage", logger,
                txtPositionDamageX, txtPositionDamageY, lblIterationCurrentDamage, btnIterationTotalDamage);

            tabDefenceComponent = new ClickableComponent("DefenceTab", logger,
                txtPositionTabDefenceX, txtPositionTabDefenceY, lblIterationCurrentTabDefence, btnIterationTotalTabDefence);
            healthComponent = new ClickableComponent("Health", logger,
                txtPositionHealthX, txtPositionHealthY, lblIterationCurrentHealth, btnIterationTotalHealth);


            gameState = new GameState(new List<ClickableComponent>() {
                gemsComponent,
                tabAttackComponent,
                damageComponent,
                tabDefenceComponent,
                healthComponent
            });
            gameState.Load();

        }

        private void FormTowerGame_Deactivate(object sender, EventArgs e)
        {
            var position = Cursor.Position;
            //logger.Log($"{pickLocation} location: {position.X} / {position.Y}");

            switch (pickLocation)
            {
                case EnumPositions.Gems:
                    gemsComponent.SaveData(position);
                    gameState.Save();
                    break;
                case EnumPositions.TabAttack:
                    tabAttackComponent.SaveData(position);
                    gameState.Save();
                    break;
                case EnumPositions.Damage:
                    damageComponent.SaveData(position);
                    healthComponent.SaveData(position);
                    gameState.Save();
                    break;
                case EnumPositions.TabDefence:
                    tabDefenceComponent.SaveData(position);
                    gameState.Save();
                    break;
                default:
                    logger.Log($"deactivate: no location pick");
                    break;
            }

            pickLocation = EnumPositions.None;

            btnLocationGems.Enabled = true;
            btnLocationAttackTab.Enabled = true;
            btnLocationDamage.Enabled = true;
            btnLocationDefenceTab.Enabled = true;
        }

        private void btnStartStop_Click(object sender, EventArgs e)
        {
            if (btnStartStop.Text == "Start")
            {
                btnStartStop.Text = "Stop";
                lblCounterSteps.Text = "0 / 12";

                logger.Log("Start clicker");
                timerClicks.Start();
                clickCounter = 0;

            }
            else
            {
                btnStartStop.Text = "Start";

                logger.Log("Stop clicker");
                timerClicks.Stop();
            }
        }




        private void timerClicks_Tick(object sender, EventArgs e)
        {
            clickCounter++;
            lblCounterSteps.Text = $"{clickCounter} / 12";

            switch (clickCounter)
            {
                case 1:
                    gemsComponent.Click();
                    gameState.Save();
                    break;
                case 2:
                    switch (cycleCounter % 2)
                    {
                        case 0:
                            tabAttackComponent.Click();
                            gameState.Save();
                            break;
                        case 1:
                            tabDefenceComponent.Click();
                            gameState.Save();
                            break;
                    }
                    break;
                case 3:
                    switch (cycleCounter % 2)
                    {
                        case 0:
                            damageComponent.Click();
                            gameState.Save();
                            break;
                        case 1:
                            healthComponent.Click();
                            gameState.Save();
                            break;
                    }
                    break;
                default:
                    //Log("")
                    break;

            }

            if (clickCounter >= 12)
            {
                clickCounter = 0;
                cycleCounter++;
                lblCycleCounter.Text = $"{cycleCounter}";
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            //timerClicks.pas
        }


        private void btnLocationGems_Click(object sender, EventArgs e)
        {
            pickLocation = EnumPositions.Gems;
            btnLocationGems.Enabled = false;
        }

        private void btnLocationAttackTab_Click(object sender, EventArgs e)
        {
            pickLocation = EnumPositions.TabAttack;
            btnLocationAttackTab.Enabled = false;
        }

        private void btnLocationDamage_Click(object sender, EventArgs e)
        {
            pickLocation = EnumPositions.Damage;
            btnLocationDamage.Enabled = false;
        }

        private void btnLocationDefenceTab_Click(object sender, EventArgs e)
        {
            pickLocation = EnumPositions.TabDefence;
            btnLocationDefenceTab.Enabled = false;
        }
    }
}
