namespace FormDosyası
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lvl1_1 = new System.Windows.Forms.PictureBox();
            this.lv2_1 = new System.Windows.Forms.PictureBox();
            this.lvl1_2 = new System.Windows.Forms.PictureBox();
            this.lvl1_3 = new System.Windows.Forms.PictureBox();
            this.healthText = new System.Windows.Forms.Label();
            this.armorText = new System.Windows.Forms.Label();
            this.resistanceText = new System.Windows.Forms.Label();
            this.healthNumber = new System.Windows.Forms.Label();
            this.armorNumber = new System.Windows.Forms.Label();
            this.resistanceNumber = new System.Windows.Forms.Label();
            this.e1hTxt = new System.Windows.Forms.Label();
            this.e2hTxt = new System.Windows.Forms.Label();
            this.e3hTxt = new System.Windows.Forms.Label();
            this.e1hNmb = new System.Windows.Forms.Label();
            this.e2hNmb = new System.Windows.Forms.Label();
            this.e3hNmb = new System.Windows.Forms.Label();
            this.FightButton = new System.Windows.Forms.Button();
            this.DefenseButton = new System.Windows.Forms.PictureBox();
            this.AttackButton = new System.Windows.Forms.PictureBox();
            this.Enemy1Heal = new System.Windows.Forms.PictureBox();
            this.Enemy3Heal = new System.Windows.Forms.PictureBox();
            this.Enemy2Heal = new System.Windows.Forms.PictureBox();
            this.Enemy1ActionAmount = new System.Windows.Forms.Label();
            this.Enemy3ActionAmount = new System.Windows.Forms.Label();
            this.Enemy2ActionAmount = new System.Windows.Forms.Label();
            this.Enemy1Attack = new System.Windows.Forms.PictureBox();
            this.Enemy3Attack = new System.Windows.Forms.PictureBox();
            this.Enemy2Attack = new System.Windows.Forms.PictureBox();
            this.lblEnergy = new System.Windows.Forms.Label();
            this.EnergyCost1 = new System.Windows.Forms.Label();
            this.ActionAmount1 = new System.Windows.Forms.Label();
            this.EnergyCost2 = new System.Windows.Forms.Label();
            this.ActionAmount2 = new System.Windows.Forms.Label();
            this.EndTurnButton = new System.Windows.Forms.PictureBox();
            this.GameOverlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lv2_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Heal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Heal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Heal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Attack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndTurnButton)).BeginInit();
            this.SuspendLayout();
            // 
            // lvl1_1
            // 
            this.lvl1_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl1_1.Image = global::FormDosyası.Properties.Resources.lv1_enemy1;
            this.lvl1_1.Location = new System.Drawing.Point(140, 166);
            this.lvl1_1.Name = "lvl1_1";
            this.lvl1_1.Size = new System.Drawing.Size(112, 134);
            this.lvl1_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lvl1_1.TabIndex = 0;
            this.lvl1_1.TabStop = false;
            this.lvl1_1.Visible = false;
            this.lvl1_1.Click += new System.EventHandler(this.lvl1_1_Click);
            // 
            // lv2_1
            // 
            this.lv2_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lv2_1.Image = global::FormDosyası.Properties.Resources.lv2_enemy;
            this.lv2_1.Location = new System.Drawing.Point(350, 166);
            this.lv2_1.Name = "lv2_1";
            this.lv2_1.Size = new System.Drawing.Size(99, 136);
            this.lv2_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lv2_1.TabIndex = 1;
            this.lv2_1.TabStop = false;
            this.lv2_1.Visible = false;
            // 
            // lvl1_2
            // 
            this.lvl1_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl1_2.Image = global::FormDosyası.Properties.Resources.lv1_enemy1;
            this.lvl1_2.Location = new System.Drawing.Point(350, 168);
            this.lvl1_2.Name = "lvl1_2";
            this.lvl1_2.Size = new System.Drawing.Size(112, 134);
            this.lvl1_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lvl1_2.TabIndex = 2;
            this.lvl1_2.TabStop = false;
            this.lvl1_2.Tag = "anan";
            this.lvl1_2.Visible = false;
            this.lvl1_2.Click += new System.EventHandler(this.lvl1_2_Click);
            // 
            // lvl1_3
            // 
            this.lvl1_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvl1_3.Image = global::FormDosyası.Properties.Resources.lv1_enemy1;
            this.lvl1_3.Location = new System.Drawing.Point(552, 166);
            this.lvl1_3.Name = "lvl1_3";
            this.lvl1_3.Size = new System.Drawing.Size(112, 134);
            this.lvl1_3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.lvl1_3.TabIndex = 3;
            this.lvl1_3.TabStop = false;
            this.lvl1_3.Visible = false;
            this.lvl1_3.Click += new System.EventHandler(this.lvl1_3_Click);
            // 
            // healthText
            // 
            this.healthText.AutoSize = true;
            this.healthText.BackColor = System.Drawing.Color.Transparent;
            this.healthText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.healthText.Location = new System.Drawing.Point(12, 9);
            this.healthText.Name = "healthText";
            this.healthText.Size = new System.Drawing.Size(120, 38);
            this.healthText.TabIndex = 4;
            this.healthText.Text = "Health ";
            // 
            // armorText
            // 
            this.armorText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.armorText.AutoSize = true;
            this.armorText.BackColor = System.Drawing.Color.Transparent;
            this.armorText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorText.ForeColor = System.Drawing.Color.SlateGray;
            this.armorText.Location = new System.Drawing.Point(210, 9);
            this.armorText.Name = "armorText";
            this.armorText.Size = new System.Drawing.Size(106, 38);
            this.armorText.TabIndex = 5;
            this.armorText.Text = "Armor";
            // 
            // resistanceText
            // 
            this.resistanceText.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resistanceText.AutoSize = true;
            this.resistanceText.BackColor = System.Drawing.Color.Transparent;
            this.resistanceText.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistanceText.ForeColor = System.Drawing.Color.Blue;
            this.resistanceText.Location = new System.Drawing.Point(469, 9);
            this.resistanceText.Name = "resistanceText";
            this.resistanceText.Size = new System.Drawing.Size(180, 38);
            this.resistanceText.TabIndex = 6;
            this.resistanceText.Text = "Resistance";
            // 
            // healthNumber
            // 
            this.healthNumber.AutoSize = true;
            this.healthNumber.BackColor = System.Drawing.Color.Transparent;
            this.healthNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.healthNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.healthNumber.Location = new System.Drawing.Point(117, 9);
            this.healthNumber.Name = "healthNumber";
            this.healthNumber.Size = new System.Drawing.Size(98, 38);
            this.healthNumber.TabIndex = 7;
            this.healthNumber.Text = "50/50";
            // 
            // armorNumber
            // 
            this.armorNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.armorNumber.AutoSize = true;
            this.armorNumber.BackColor = System.Drawing.Color.Transparent;
            this.armorNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.armorNumber.ForeColor = System.Drawing.Color.SlateGray;
            this.armorNumber.Location = new System.Drawing.Point(322, 9);
            this.armorNumber.Name = "armorNumber";
            this.armorNumber.Size = new System.Drawing.Size(35, 38);
            this.armorNumber.TabIndex = 8;
            this.armorNumber.Text = "0";
            // 
            // resistanceNumber
            // 
            this.resistanceNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resistanceNumber.AutoSize = true;
            this.resistanceNumber.BackColor = System.Drawing.Color.Transparent;
            this.resistanceNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resistanceNumber.ForeColor = System.Drawing.Color.Blue;
            this.resistanceNumber.Location = new System.Drawing.Point(647, 9);
            this.resistanceNumber.Name = "resistanceNumber";
            this.resistanceNumber.Size = new System.Drawing.Size(35, 38);
            this.resistanceNumber.TabIndex = 9;
            this.resistanceNumber.Text = "0";
            // 
            // e1hTxt
            // 
            this.e1hTxt.AutoSize = true;
            this.e1hTxt.BackColor = System.Drawing.Color.Transparent;
            this.e1hTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1hTxt.ForeColor = System.Drawing.Color.Red;
            this.e1hTxt.Location = new System.Drawing.Point(135, 315);
            this.e1hTxt.Name = "e1hTxt";
            this.e1hTxt.Size = new System.Drawing.Size(97, 32);
            this.e1hTxt.TabIndex = 10;
            this.e1hTxt.Text = "Health";
            this.e1hTxt.Visible = false;
            // 
            // e2hTxt
            // 
            this.e2hTxt.AutoSize = true;
            this.e2hTxt.BackColor = System.Drawing.Color.Transparent;
            this.e2hTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2hTxt.ForeColor = System.Drawing.Color.Red;
            this.e2hTxt.Location = new System.Drawing.Point(344, 315);
            this.e2hTxt.Name = "e2hTxt";
            this.e2hTxt.Size = new System.Drawing.Size(97, 32);
            this.e2hTxt.TabIndex = 11;
            this.e2hTxt.Text = "Health";
            this.e2hTxt.Visible = false;
            // 
            // e3hTxt
            // 
            this.e3hTxt.AutoSize = true;
            this.e3hTxt.BackColor = System.Drawing.Color.Transparent;
            this.e3hTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e3hTxt.ForeColor = System.Drawing.Color.Red;
            this.e3hTxt.Location = new System.Drawing.Point(546, 315);
            this.e3hTxt.Name = "e3hTxt";
            this.e3hTxt.Size = new System.Drawing.Size(97, 32);
            this.e3hTxt.TabIndex = 12;
            this.e3hTxt.Tag = "fight";
            this.e3hTxt.Text = "Health";
            this.e3hTxt.Visible = false;
            // 
            // e1hNmb
            // 
            this.e1hNmb.AutoSize = true;
            this.e1hNmb.BackColor = System.Drawing.Color.Transparent;
            this.e1hNmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e1hNmb.ForeColor = System.Drawing.Color.Red;
            this.e1hNmb.Location = new System.Drawing.Point(226, 315);
            this.e1hNmb.Name = "e1hNmb";
            this.e1hNmb.Size = new System.Drawing.Size(30, 32);
            this.e1hNmb.TabIndex = 13;
            this.e1hNmb.Text = "0";
            this.e1hNmb.Visible = false;
            // 
            // e2hNmb
            // 
            this.e2hNmb.AutoSize = true;
            this.e2hNmb.BackColor = System.Drawing.Color.Transparent;
            this.e2hNmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e2hNmb.ForeColor = System.Drawing.Color.Red;
            this.e2hNmb.Location = new System.Drawing.Point(432, 315);
            this.e2hNmb.Name = "e2hNmb";
            this.e2hNmb.Size = new System.Drawing.Size(30, 32);
            this.e2hNmb.TabIndex = 14;
            this.e2hNmb.Text = "0";
            this.e2hNmb.Visible = false;
            // 
            // e3hNmb
            // 
            this.e3hNmb.AutoSize = true;
            this.e3hNmb.BackColor = System.Drawing.Color.Transparent;
            this.e3hNmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.e3hNmb.ForeColor = System.Drawing.Color.Red;
            this.e3hNmb.Location = new System.Drawing.Point(639, 315);
            this.e3hNmb.Name = "e3hNmb";
            this.e3hNmb.Size = new System.Drawing.Size(30, 32);
            this.e3hNmb.TabIndex = 15;
            this.e3hNmb.Text = "0";
            this.e3hNmb.Visible = false;
            // 
            // FightButton
            // 
            this.FightButton.Location = new System.Drawing.Point(329, 187);
            this.FightButton.Name = "FightButton";
            this.FightButton.Size = new System.Drawing.Size(189, 97);
            this.FightButton.TabIndex = 16;
            this.FightButton.Text = "Begin Fighting";
            this.FightButton.UseVisualStyleBackColor = true;
            this.FightButton.Click += new System.EventHandler(this.FightButton_Click);
            // 
            // DefenseButton
            // 
            this.DefenseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DefenseButton.Image = ((System.Drawing.Image)(resources.GetObject("DefenseButton.Image")));
            this.DefenseButton.Location = new System.Drawing.Point(247, 412);
            this.DefenseButton.Name = "DefenseButton";
            this.DefenseButton.Size = new System.Drawing.Size(153, 73);
            this.DefenseButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DefenseButton.TabIndex = 17;
            this.DefenseButton.TabStop = false;
            this.DefenseButton.Visible = false;
            this.DefenseButton.Click += new System.EventHandler(this.DefenseButton_Click);
            // 
            // AttackButton
            // 
            this.AttackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AttackButton.Image = ((System.Drawing.Image)(resources.GetObject("AttackButton.Image")));
            this.AttackButton.Location = new System.Drawing.Point(19, 412);
            this.AttackButton.Name = "AttackButton";
            this.AttackButton.Size = new System.Drawing.Size(153, 73);
            this.AttackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AttackButton.TabIndex = 18;
            this.AttackButton.TabStop = false;
            this.AttackButton.Visible = false;
            this.AttackButton.Click += new System.EventHandler(this.AttackButton_Click);
            // 
            // Enemy1Heal
            // 
            this.Enemy1Heal.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1Heal.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1Heal.Image")));
            this.Enemy1Heal.Location = new System.Drawing.Point(141, 101);
            this.Enemy1Heal.Name = "Enemy1Heal";
            this.Enemy1Heal.Size = new System.Drawing.Size(63, 59);
            this.Enemy1Heal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1Heal.TabIndex = 20;
            this.Enemy1Heal.TabStop = false;
            // 
            // Enemy3Heal
            // 
            this.Enemy3Heal.BackColor = System.Drawing.Color.Transparent;
            this.Enemy3Heal.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3Heal.Image")));
            this.Enemy3Heal.Location = new System.Drawing.Point(552, 101);
            this.Enemy3Heal.Name = "Enemy3Heal";
            this.Enemy3Heal.Size = new System.Drawing.Size(63, 59);
            this.Enemy3Heal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3Heal.TabIndex = 21;
            this.Enemy3Heal.TabStop = false;
            // 
            // Enemy2Heal
            // 
            this.Enemy2Heal.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2Heal.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2Heal.Image")));
            this.Enemy2Heal.Location = new System.Drawing.Point(350, 101);
            this.Enemy2Heal.Name = "Enemy2Heal";
            this.Enemy2Heal.Size = new System.Drawing.Size(63, 59);
            this.Enemy2Heal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2Heal.TabIndex = 22;
            this.Enemy2Heal.TabStop = false;
            // 
            // Enemy1ActionAmount
            // 
            this.Enemy1ActionAmount.AutoSize = true;
            this.Enemy1ActionAmount.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1ActionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy1ActionAmount.ForeColor = System.Drawing.Color.Red;
            this.Enemy1ActionAmount.Location = new System.Drawing.Point(210, 118);
            this.Enemy1ActionAmount.Name = "Enemy1ActionAmount";
            this.Enemy1ActionAmount.Size = new System.Drawing.Size(46, 32);
            this.Enemy1ActionAmount.TabIndex = 23;
            this.Enemy1ActionAmount.Text = "10";
            // 
            // Enemy3ActionAmount
            // 
            this.Enemy3ActionAmount.AutoSize = true;
            this.Enemy3ActionAmount.BackColor = System.Drawing.Color.Transparent;
            this.Enemy3ActionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy3ActionAmount.ForeColor = System.Drawing.Color.Red;
            this.Enemy3ActionAmount.Location = new System.Drawing.Point(623, 118);
            this.Enemy3ActionAmount.Name = "Enemy3ActionAmount";
            this.Enemy3ActionAmount.Size = new System.Drawing.Size(46, 32);
            this.Enemy3ActionAmount.TabIndex = 24;
            this.Enemy3ActionAmount.Text = "10";
            // 
            // Enemy2ActionAmount
            // 
            this.Enemy2ActionAmount.AutoSize = true;
            this.Enemy2ActionAmount.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2ActionAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enemy2ActionAmount.ForeColor = System.Drawing.Color.Red;
            this.Enemy2ActionAmount.Location = new System.Drawing.Point(419, 118);
            this.Enemy2ActionAmount.Name = "Enemy2ActionAmount";
            this.Enemy2ActionAmount.Size = new System.Drawing.Size(46, 32);
            this.Enemy2ActionAmount.TabIndex = 25;
            this.Enemy2ActionAmount.Text = "10";
            // 
            // Enemy1Attack
            // 
            this.Enemy1Attack.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1Attack.Image = ((System.Drawing.Image)(resources.GetObject("Enemy1Attack.Image")));
            this.Enemy1Attack.Location = new System.Drawing.Point(141, 101);
            this.Enemy1Attack.Name = "Enemy1Attack";
            this.Enemy1Attack.Size = new System.Drawing.Size(63, 59);
            this.Enemy1Attack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1Attack.TabIndex = 26;
            this.Enemy1Attack.TabStop = false;
            // 
            // Enemy3Attack
            // 
            this.Enemy3Attack.BackColor = System.Drawing.Color.Transparent;
            this.Enemy3Attack.Image = ((System.Drawing.Image)(resources.GetObject("Enemy3Attack.Image")));
            this.Enemy3Attack.Location = new System.Drawing.Point(552, 101);
            this.Enemy3Attack.Name = "Enemy3Attack";
            this.Enemy3Attack.Size = new System.Drawing.Size(63, 59);
            this.Enemy3Attack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy3Attack.TabIndex = 27;
            this.Enemy3Attack.TabStop = false;
            // 
            // Enemy2Attack
            // 
            this.Enemy2Attack.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2Attack.Image = ((System.Drawing.Image)(resources.GetObject("Enemy2Attack.Image")));
            this.Enemy2Attack.Location = new System.Drawing.Point(350, 101);
            this.Enemy2Attack.Name = "Enemy2Attack";
            this.Enemy2Attack.Size = new System.Drawing.Size(63, 59);
            this.Enemy2Attack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2Attack.TabIndex = 28;
            this.Enemy2Attack.TabStop = false;
            // 
            // lblEnergy
            // 
            this.lblEnergy.AutoSize = true;
            this.lblEnergy.BackColor = System.Drawing.Color.Transparent;
            this.lblEnergy.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnergy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.lblEnergy.Location = new System.Drawing.Point(670, 228);
            this.lblEnergy.Name = "lblEnergy";
            this.lblEnergy.Size = new System.Drawing.Size(118, 36);
            this.lblEnergy.TabIndex = 29;
            this.lblEnergy.Text = "Energy ";
            // 
            // EnergyCost1
            // 
            this.EnergyCost1.AutoSize = true;
            this.EnergyCost1.BackColor = System.Drawing.Color.Transparent;
            this.EnergyCost1.Font = new System.Drawing.Font("Orbitron", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyCost1.ForeColor = System.Drawing.Color.Yellow;
            this.EnergyCost1.Location = new System.Drawing.Point(12, 367);
            this.EnergyCost1.Name = "EnergyCost1";
            this.EnergyCost1.Size = new System.Drawing.Size(34, 45);
            this.EnergyCost1.TabIndex = 30;
            this.EnergyCost1.Text = "1";
            // 
            // ActionAmount1
            // 
            this.ActionAmount1.AutoSize = true;
            this.ActionAmount1.BackColor = System.Drawing.Color.Transparent;
            this.ActionAmount1.Font = new System.Drawing.Font("Orbitron", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionAmount1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ActionAmount1.Location = new System.Drawing.Point(178, 452);
            this.ActionAmount1.Name = "ActionAmount1";
            this.ActionAmount1.Size = new System.Drawing.Size(40, 36);
            this.ActionAmount1.TabIndex = 31;
            this.ActionAmount1.Text = "5";
            // 
            // EnergyCost2
            // 
            this.EnergyCost2.AutoSize = true;
            this.EnergyCost2.BackColor = System.Drawing.Color.Transparent;
            this.EnergyCost2.Font = new System.Drawing.Font("Orbitron", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnergyCost2.ForeColor = System.Drawing.Color.Yellow;
            this.EnergyCost2.Location = new System.Drawing.Point(239, 364);
            this.EnergyCost2.Name = "EnergyCost2";
            this.EnergyCost2.Size = new System.Drawing.Size(34, 45);
            this.EnergyCost2.TabIndex = 32;
            this.EnergyCost2.Text = "1";
            // 
            // ActionAmount2
            // 
            this.ActionAmount2.AutoSize = true;
            this.ActionAmount2.BackColor = System.Drawing.Color.Transparent;
            this.ActionAmount2.Font = new System.Drawing.Font("Orbitron", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActionAmount2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ActionAmount2.Location = new System.Drawing.Point(407, 449);
            this.ActionAmount2.Name = "ActionAmount2";
            this.ActionAmount2.Size = new System.Drawing.Size(40, 36);
            this.ActionAmount2.TabIndex = 33;
            this.ActionAmount2.Text = "5";
            // 
            // EndTurnButton
            // 
            this.EndTurnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.EndTurnButton.Image = ((System.Drawing.Image)(resources.GetObject("EndTurnButton.Image")));
            this.EndTurnButton.Location = new System.Drawing.Point(676, 309);
            this.EndTurnButton.Name = "EndTurnButton";
            this.EndTurnButton.Size = new System.Drawing.Size(112, 38);
            this.EndTurnButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EndTurnButton.TabIndex = 34;
            this.EndTurnButton.TabStop = false;
            this.EndTurnButton.Click += new System.EventHandler(this.EndTurnButton_Click);
            // 
            // GameOverlbl
            // 
            this.GameOverlbl.AutoSize = true;
            this.GameOverlbl.BackColor = System.Drawing.Color.Transparent;
            this.GameOverlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GameOverlbl.ForeColor = System.Drawing.Color.Red;
            this.GameOverlbl.Location = new System.Drawing.Point(786, 467);
            this.GameOverlbl.Name = "GameOverlbl";
            this.GameOverlbl.Size = new System.Drawing.Size(676, 135);
            this.GameOverlbl.TabIndex = 35;
            this.GameOverlbl.Text = "Game Over";
            this.GameOverlbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FormDosyası.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(823, 497);
            this.Controls.Add(this.GameOverlbl);
            this.Controls.Add(this.EndTurnButton);
            this.Controls.Add(this.ActionAmount2);
            this.Controls.Add(this.EnergyCost2);
            this.Controls.Add(this.ActionAmount1);
            this.Controls.Add(this.EnergyCost1);
            this.Controls.Add(this.lblEnergy);
            this.Controls.Add(this.Enemy2Attack);
            this.Controls.Add(this.Enemy3Attack);
            this.Controls.Add(this.Enemy1Attack);
            this.Controls.Add(this.Enemy2ActionAmount);
            this.Controls.Add(this.Enemy3ActionAmount);
            this.Controls.Add(this.Enemy1ActionAmount);
            this.Controls.Add(this.Enemy2Heal);
            this.Controls.Add(this.Enemy3Heal);
            this.Controls.Add(this.Enemy1Heal);
            this.Controls.Add(this.AttackButton);
            this.Controls.Add(this.DefenseButton);
            this.Controls.Add(this.FightButton);
            this.Controls.Add(this.e3hNmb);
            this.Controls.Add(this.e2hNmb);
            this.Controls.Add(this.e1hNmb);
            this.Controls.Add(this.e3hTxt);
            this.Controls.Add(this.e2hTxt);
            this.Controls.Add(this.e1hTxt);
            this.Controls.Add(this.resistanceNumber);
            this.Controls.Add(this.armorNumber);
            this.Controls.Add(this.healthNumber);
            this.Controls.Add(this.resistanceText);
            this.Controls.Add(this.armorText);
            this.Controls.Add(this.healthText);
            this.Controls.Add(this.lvl1_3);
            this.Controls.Add(this.lvl1_2);
            this.Controls.Add(this.lv2_1);
            this.Controls.Add(this.lvl1_1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lv2_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lvl1_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DefenseButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Heal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Heal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Heal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1Attack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy3Attack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2Attack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndTurnButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox lvl1_1;
        private System.Windows.Forms.PictureBox lv2_1;
        private System.Windows.Forms.PictureBox lvl1_2;
        private System.Windows.Forms.PictureBox lvl1_3;
        private System.Windows.Forms.Label healthText;
        private System.Windows.Forms.Label armorText;
        private System.Windows.Forms.Label resistanceText;
        private System.Windows.Forms.Label healthNumber;
        private System.Windows.Forms.Label armorNumber;
        private System.Windows.Forms.Label resistanceNumber;
        private System.Windows.Forms.Label e1hTxt;
        private System.Windows.Forms.Label e2hTxt;
        private System.Windows.Forms.Label e3hTxt;
        private System.Windows.Forms.Label e1hNmb;
        private System.Windows.Forms.Label e2hNmb;
        private System.Windows.Forms.Label e3hNmb;
        private System.Windows.Forms.Button FightButton;
        private System.Windows.Forms.PictureBox DefenseButton;
        private System.Windows.Forms.PictureBox AttackButton;
        private System.Windows.Forms.PictureBox Enemy1Heal;
        private System.Windows.Forms.PictureBox Enemy3Heal;
        private System.Windows.Forms.PictureBox Enemy2Heal;
        private System.Windows.Forms.Label Enemy1ActionAmount;
        private System.Windows.Forms.Label Enemy3ActionAmount;
        private System.Windows.Forms.Label Enemy2ActionAmount;
        private System.Windows.Forms.PictureBox Enemy1Attack;
        private System.Windows.Forms.PictureBox Enemy3Attack;
        private System.Windows.Forms.PictureBox Enemy2Attack;
        private System.Windows.Forms.Label lblEnergy;
        private System.Windows.Forms.Label EnergyCost1;
        private System.Windows.Forms.Label ActionAmount1;
        private System.Windows.Forms.Label EnergyCost2;
        private System.Windows.Forms.Label ActionAmount2;
        private System.Windows.Forms.PictureBox EndTurnButton;
        private System.Windows.Forms.Label GameOverlbl;
    }
}

