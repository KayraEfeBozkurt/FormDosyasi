using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
namespace FormDosyası
{
    public partial class Form1 : Form
    {
        Form2 BountyScene = new Form2();
        SoundPlayer Swing = new SoundPlayer(@"C:\Users\Kayra\Downloads\Knightly-sword-swing-fast-162.wav");
        SoundPlayer ArmorSound = new SoundPlayer(@"C:\Users\Kayra\Downloads\Armor Sound.wav");
        enemy lv1 = new enemy();
        int IncomingDamage = 0;
        int[] enemyLevels = new int[3];
        bool[] enemyWillHeal;
        int Health = 50;
        int MaxHealth = 50;
        int e1Health;
        int e2Health;
        int e3Health;
        int energy = 0;
        int MaxEnergy = 10;
        int AttackDamage = 5;
        int armor;
        int armorDecreasing;
        bool Attacking = false;
        Random rd = new Random();
        List<System.Windows.Forms.PictureBox> FightScene1 = new List<System.Windows.Forms.PictureBox>();
        List<System.Windows.Forms.Label> FightScene2 = new List<System.Windows.Forms.Label>();
            
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            FightButton.Visible = true;
            lv1.health = 16;
            lv1.attack = 4;
            lv1.resistance = 0;
            enemyLevels = new int[3] {1,1,1};
            enemyWillHeal = new bool[] { false, false, false };
            #region
            FightScene2.Add(e1hNmb);
            FightScene2.Add(e2hNmb);
            FightScene2.Add(e3hNmb);
            FightScene2.Add(e1hTxt);
            FightScene2.Add(e2hTxt);
            FightScene2.Add(e3hTxt);
            FightScene2.Add(EnergyCost1);
            FightScene2.Add(EnergyCost2);
            FightScene2.Add(ActionAmount1);
            FightScene2.Add(ActionAmount2);
            FightScene2.Add(lblEnergy);
            FightScene2.Add(Enemy1ActionAmount);
            FightScene2.Add(Enemy2ActionAmount);
            FightScene2.Add(Enemy3ActionAmount);
            FightScene1.Add(lvl1_1);
            FightScene1.Add(lvl1_2);
            FightScene1.Add(lvl1_3);
            FightScene1.Add(AttackButton);
            FightScene1.Add(DefenseButton);
            FightScene1.Add(Enemy1Attack);
            FightScene1.Add(Enemy2Attack);
            FightScene1.Add(Enemy3Attack);
            FightScene1.Add(Enemy1Heal);
            FightScene1.Add(Enemy2Heal);
            FightScene1.Add(Enemy3Heal);
            FightScene1.Add(EndTurnButton);

            #endregion
            ClearAll();
        }

        private void FightButton_Click(object sender, EventArgs e)
        {
            BountyScene.Show();
            this.Close();

            e1Health = lv1.health + rd.Next(1, 5);
            e2Health = lv1.health + rd.Next(1, 5);
            e3Health = lv1.health + rd.Next(1, 5);
            e1hNmb.Text = e1Health.ToString();
            e2hNmb.Text = e2Health.ToString();
            e3hNmb.Text = e3Health.ToString();
            fighting();
            EnergyChanging(4);
            FightButton.Visible = false;
            EnemyAction();
            
        }
        void fighting()
        {
            ClearAll();
            foreach (var obj in FightScene1)
            {
                obj.Visible = true;
            }
            foreach (var obj in FightScene2)
            {
                obj.Visible = true;
            }

        }
        void ClearAll()
        {
            foreach (var obj in FightScene1)
            {
                obj.Visible = false;
            }
            foreach (var obj in FightScene2)
            {
                obj.Visible = false;
            }
        }
        void EnergyChanging(int a)
        {
            energy += a;
            if (energy > MaxEnergy)
                energy = MaxEnergy;
            lblEnergy.Text = "Energy " + MaxEnergy.ToString() + "/" + energy.ToString();

        }

        void HealthChanging(int a)
        {
            Health += a;
            if (Health > MaxHealth)
                Health = MaxHealth;
            healthNumber.Text = MaxHealth.ToString() + "/" + Health.ToString();
            if (Health <= 0)
            {
                ClearAll();
                GameOverlbl.Location = new Point(65, 180);
                GameOverlbl.Visible = true;
            }
            }
        
        void ArmorChanging(int a)
        {
            armor += a;
            if (armor < 0)
                armor = 0;
            armorNumber.Text = armor.ToString();
        }

        private void AttackButton_Click(object sender, EventArgs e)
        {
            if (Attacking)
            {
                MessageBox.Show("You have already clicked, now select the enemy you want to attack ");

            }
            else
            {
                if (energy > 0)
                {


                    Attacking = true;
                    EnergyChanging(-1);
                }
                else
                    MessageBox.Show("You don't have enough energy");
            }
        }

        

        private void lvl1_1_Click(object sender, EventArgs e)
        {
            
            if (Attacking)
            { 
                EnemyHealthChange(1, AttackDamage);
                Attacking = false;
                Swing.Play();
            }
            else
                MessageBox.Show("First choose the action");
            if (e1Health <= 0)
                EnemyDied(1);
        }
        void EnemyHealthChange(int enemyNumber, int AmountOfDamage)
        {
            switch (enemyNumber)
            {
                case 1:
                    e1Health -= AmountOfDamage;
                    e1hNmb.Text = e1Health.ToString();
                    break;
                case 2:
                    e2Health -= AmountOfDamage;
                    e2hNmb.Text = e2Health.ToString();
                    break;
                case 3:
                    e3Health -= AmountOfDamage;
                    e3hNmb.Text = e3Health.ToString();
                    break;

            }
        }
        public class enemy
        {
            public int health;
            public int attack;
            public int resistance;
        }

        private void lvl1_2_Click(object sender, EventArgs e)
        {       
            if (Attacking)
            {
                EnemyHealthChange(2, AttackDamage);
                Attacking = false;
                Swing.Play();
            }
            else
                MessageBox.Show("First choose the action");
            if (e2Health <= 0)
                EnemyDied(2);
        }

        private void lvl1_3_Click(object sender, EventArgs e)
        {
            
            if (Attacking)
            {
                EnemyHealthChange(3, AttackDamage);
                Attacking = false;
                Swing.Play();
            }
            else
                MessageBox.Show("First choose the action");
            if (e3Health <= 0)
                EnemyDied(3);
        }
        

        private void DefenseButton_Click(object sender, EventArgs e)
        {
            if (energy > 0)
            {


                ArmorSound.Play();
                ArmorChanging(5);
                EnergyChanging(-1);
            }
            else
                MessageBox.Show("You don't have enough energy");
            
        }

        private void EndTurnButton_Click(object sender, EventArgs e)
        {
            
            if (enemyWillHeal[0])
            {
                EnemyHealthChange(1, -1 * Convert.ToInt32(Enemy1ActionAmount.Text));
                enemyWillHeal[0] = false;
            }
            if (enemyWillHeal[1])
            {
                EnemyHealthChange(2, -1 * Convert.ToInt32(Enemy2ActionAmount.Text));
                enemyWillHeal[1] = false;
            }
            if (enemyWillHeal[2])
            {
                EnemyHealthChange(3, -1 * Convert.ToInt32(Enemy3ActionAmount.Text));
                enemyWillHeal[2] = false;
            }
            armorDecreasing = IncomingDamage;
            IncomingDamage += armor;
            if (IncomingDamage > 0)
                IncomingDamage = 0;
            ArmorChanging(armorDecreasing);
            
            HealthChanging(IncomingDamage);
            if (IncomingDamage != 0)
            MessageBox.Show("You got " + -1*IncomingDamage + " damage");
            IncomingDamage = 0;
            EnergyChanging(3);
            EnemyAction();
            
            
            
        }
        void EnemyDied(int EnemyNumber)
        {
            if(EnemyNumber == 1)
            {
                Enemy1ActionAmount.Visible = false;
                Enemy1Attack.Visible = false;
                Enemy1Heal.Visible = false;
                lvl1_1.Visible = false;
                e1hTxt.Visible = false;
                e1hNmb.Visible = false;
                enemyLevels[0] = 0;
            }
            if (EnemyNumber == 2)
            {
                Enemy2ActionAmount.Visible = false;
                Enemy2Attack.Visible = false;
                Enemy2Heal.Visible = false;
                lvl1_2.Visible = false;
                e2hTxt.Visible = false;
                e2hNmb.Visible = false;
                enemyLevels[1] = 0;
            }
            if (EnemyNumber == 3)
            {
                Enemy3ActionAmount.Visible = false;
                Enemy3Attack.Visible = false;
                Enemy3Heal.Visible = false;
                lvl1_3.Visible = false;
                e3hTxt.Visible = false;
                e3hNmb.Visible = false;
                enemyLevels[2] = 0;
            }
        }
        
        void EnemyAction()
        {
            for (int i = 0; i < 3; i++)
            {
                if(enemyLevels[i] == 1)
                {
                    if (i == 0)
                    {
                        Enemy1ActionAmount.Text = (lv1.attack + rd.Next(0, 3)).ToString();
                        if (rd.Next(1, 4) < 3)
                        {
                            Enemy1Attack.Visible = true;
                            Enemy1Heal.Visible = false;
                            IncomingDamage -= Convert.ToInt32(Enemy1ActionAmount.Text);
                        }
                        else
                        {
                            Enemy1Attack.Visible = false;
                            
                            Enemy1Heal.Visible = true;
                            enemyWillHeal[0] = true; 
                        }
                           
                    }
                    if (i == 1)
                    {
                        Enemy2ActionAmount.Text = (lv1.attack + rd.Next(0, 3)).ToString();
                        if (rd.Next(1, 4) < 3)
                        {
                            Enemy2Attack.Visible = true;
                            Enemy2Heal.Visible = false;
                            IncomingDamage -= Convert.ToInt32(Enemy2ActionAmount.Text);

                        }
                        else
                        {
                            Enemy2Attack.Visible = false;
                            Enemy2Heal.Visible = true;
                            enemyWillHeal[1] = true;
                        }

                    }
                    if (i == 2)
                    {
                        Enemy3ActionAmount.Text = (lv1.attack + rd.Next(0, 3)).ToString();
                        if (rd.Next(1, 4) < 3)
                        {
                            Enemy3Attack.Visible = true;
                            Enemy3Heal.Visible = false;
                            IncomingDamage -= Convert.ToInt32(Enemy3ActionAmount.Text);

                        }
                        else
                        {
                            Enemy3Attack.Visible = false;
                            Enemy3Heal.Visible = true;
                            enemyWillHeal[2] = true;
                        }

                    }
                }
            }
        }

        
    }
}