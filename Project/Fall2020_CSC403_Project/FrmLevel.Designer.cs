﻿namespace Fall2020_CSC403_Project {
  partial class FrmLevel {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLevel));
            this.lblInGameTime = new System.Windows.Forms.Label();
            this.tmrUpdateInGameTime = new System.Windows.Forms.Timer(this.components);
            this.tmrPlayerMove = new System.Windows.Forms.Timer(this.components);
            this.tmrEnemyMove = new System.Windows.Forms.Timer(this.components);
            this.picEnemyCheeto = new System.Windows.Forms.PictureBox();
            this.picEnemyPoisonPacket = new System.Windows.Forms.PictureBox();
            this.picWall3 = new System.Windows.Forms.PictureBox();
            this.picBossKoolAid = new System.Windows.Forms.PictureBox();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picWall5 = new System.Windows.Forms.PictureBox();
            this.picWall4 = new System.Windows.Forms.PictureBox();
            this.picWall12 = new System.Windows.Forms.PictureBox();
            this.picWall6 = new System.Windows.Forms.PictureBox();
            this.picWall9 = new System.Windows.Forms.PictureBox();
            this.picWall10 = new System.Windows.Forms.PictureBox();
            this.picWall0 = new System.Windows.Forms.PictureBox();
            this.picWall7 = new System.Windows.Forms.PictureBox();
            this.picWall8 = new System.Windows.Forms.PictureBox();
            this.picWall1 = new System.Windows.Forms.PictureBox();
            this.picWall2 = new System.Windows.Forms.PictureBox();
            this.picWall11 = new System.Windows.Forms.PictureBox();
            this.winImage = new System.Windows.Forms.PictureBox();
            this.checkWin = new System.Windows.Forms.Timer(this.components);
            this.checkLose = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerHealthFull = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cheatMenu = new System.Windows.Forms.Panel();
            this.cheatMenuDefenseDisplay = new System.Windows.Forms.Label();
            this.cheatMenuEvasionDisplay = new System.Windows.Forms.Label();
            this.cheatMenuHealthDisplay = new System.Windows.Forms.Label();
            this.cheatMenuSpeedDisplay = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cheatMenuDefenseUpButton = new System.Windows.Forms.Button();
            this.cheatMenuEvasionUpButton = new System.Windows.Forms.Button();
            this.cheatMenuHealthUpButton = new System.Windows.Forms.Button();
            this.cheatMenuSpeedUpButton = new System.Windows.Forms.Button();
            this.cheatMenuDefenseLabel = new System.Windows.Forms.Label();
            this.cheatMenuEvasionLabel = new System.Windows.Forms.Label();
            this.cheatMenuHealthLabel = new System.Windows.Forms.Label();
            this.cheatMenuSpeedLabel = new System.Windows.Forms.Label();
            this.cheatMenuDefenseDownButton = new System.Windows.Forms.Button();
            this.cheatMenuEvasionDownButton = new System.Windows.Forms.Button();
            this.cheatMenuHealthDownButton = new System.Windows.Forms.Button();
            this.cheatMenuSpeedDownButton = new System.Windows.Forms.Button();
            this.cheatMenuWinButton = new System.Windows.Forms.Button();
            this.cheatMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.cheatMenuExitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cheatMenuUpdater = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winImage)).BeginInit();
            this.cheatMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheatMenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInGameTime
            // 
            this.lblInGameTime.AutoSize = true;
            this.lblInGameTime.BackColor = System.Drawing.Color.Black;
            this.lblInGameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInGameTime.ForeColor = System.Drawing.Color.White;
            this.lblInGameTime.Location = new System.Drawing.Point(12, 9);
            this.lblInGameTime.Name = "lblInGameTime";
            this.lblInGameTime.Size = new System.Drawing.Size(46, 18);
            this.lblInGameTime.TabIndex = 2;
            this.lblInGameTime.Text = "label1";
            this.lblInGameTime.Click += new System.EventHandler(this.lblInGameTime_Click);
            // 
            // tmrUpdateInGameTime
            // 
            this.tmrUpdateInGameTime.Enabled = true;
            this.tmrUpdateInGameTime.Tick += new System.EventHandler(this.tmrUpdateInGameTime_Tick);
            // 
            // tmrPlayerMove
            // 
            this.tmrPlayerMove.Enabled = true;
            this.tmrPlayerMove.Interval = 10;
            this.tmrPlayerMove.Tick += new System.EventHandler(this.tmrPlayerMove_Tick);
            // 
            // tmrEnemyMove
            // 
            this.tmrEnemyMove.Enabled = true;
            this.tmrEnemyMove.Interval = 10;
            this.tmrEnemyMove.Tick += new System.EventHandler(this.tmrEnemyMove_Tick);
            // 
            // picEnemyCheeto
            // 
            this.picEnemyCheeto.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyCheeto.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_cheetos;
            this.picEnemyCheeto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyCheeto.Location = new System.Drawing.Point(838, 540);
            this.picEnemyCheeto.Name = "picEnemyCheeto";
            this.picEnemyCheeto.Size = new System.Drawing.Size(64, 107);
            this.picEnemyCheeto.TabIndex = 5;
            this.picEnemyCheeto.TabStop = false;
            // 
            // picEnemyPoisonPacket
            // 
            this.picEnemyPoisonPacket.BackColor = System.Drawing.Color.Transparent;
            this.picEnemyPoisonPacket.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.enemy_poisonpacket;
            this.picEnemyPoisonPacket.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picEnemyPoisonPacket.Location = new System.Drawing.Point(110, 98);
            this.picEnemyPoisonPacket.Name = "picEnemyPoisonPacket";
            this.picEnemyPoisonPacket.Size = new System.Drawing.Size(63, 96);
            this.picEnemyPoisonPacket.TabIndex = 4;
            this.picEnemyPoisonPacket.TabStop = false;
            // 
            // picWall3
            // 
            this.picWall3.BackColor = System.Drawing.Color.Transparent;
            this.picWall3.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall3.Location = new System.Drawing.Point(2, 388);
            this.picWall3.Name = "picWall3";
            this.picWall3.Size = new System.Drawing.Size(358, 67);
            this.picWall3.TabIndex = 3;
            this.picWall3.TabStop = false;
            // 
            // picBossKoolAid
            // 
            this.picBossKoolAid.BackColor = System.Drawing.Color.Transparent;
            this.picBossKoolAid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picBossKoolAid.BackgroundImage")));
            this.picBossKoolAid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBossKoolAid.Location = new System.Drawing.Point(971, 74);
            this.picBossKoolAid.Name = "picBossKoolAid";
            this.picBossKoolAid.Size = new System.Drawing.Size(193, 194);
            this.picBossKoolAid.TabIndex = 1;
            this.picBossKoolAid.TabStop = false;
            // 
            // picPlayer
            // 
            this.picPlayer.BackColor = System.Drawing.Color.Transparent;
            this.picPlayer.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.player;
            this.picPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picPlayer.Location = new System.Drawing.Point(119, 510);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(54, 106);
            this.picPlayer.TabIndex = 0;
            this.picPlayer.TabStop = false;
            // 
            // picWall5
            // 
            this.picWall5.BackColor = System.Drawing.Color.Transparent;
            this.picWall5.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall5.Location = new System.Drawing.Point(2, 656);
            this.picWall5.Name = "picWall5";
            this.picWall5.Size = new System.Drawing.Size(358, 67);
            this.picWall5.TabIndex = 6;
            this.picWall5.TabStop = false;
            // 
            // picWall4
            // 
            this.picWall4.BackColor = System.Drawing.Color.Transparent;
            this.picWall4.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall4.Location = new System.Drawing.Point(2, 454);
            this.picWall4.Name = "picWall4";
            this.picWall4.Size = new System.Drawing.Size(82, 203);
            this.picWall4.TabIndex = 7;
            this.picWall4.TabStop = false;
            // 
            // picWall12
            // 
            this.picWall12.BackColor = System.Drawing.Color.Transparent;
            this.picWall12.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall12.Location = new System.Drawing.Point(890, 397);
            this.picWall12.Name = "picWall12";
            this.picWall12.Size = new System.Drawing.Size(203, 113);
            this.picWall12.TabIndex = 8;
            this.picWall12.TabStop = false;
            // 
            // picWall6
            // 
            this.picWall6.BackColor = System.Drawing.Color.Transparent;
            this.picWall6.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall6.Location = new System.Drawing.Point(357, 656);
            this.picWall6.Name = "picWall6";
            this.picWall6.Size = new System.Drawing.Size(358, 67);
            this.picWall6.TabIndex = 9;
            this.picWall6.TabStop = false;
            // 
            // picWall9
            // 
            this.picWall9.BackColor = System.Drawing.Color.Transparent;
            this.picWall9.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall9.Location = new System.Drawing.Point(266, 154);
            this.picWall9.Name = "picWall9";
            this.picWall9.Size = new System.Drawing.Size(197, 118);
            this.picWall9.TabIndex = 10;
            this.picWall9.TabStop = false;
            // 
            // picWall10
            // 
            this.picWall10.BackColor = System.Drawing.Color.Transparent;
            this.picWall10.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall10.Location = new System.Drawing.Point(653, 89);
            this.picWall10.Name = "picWall10";
            this.picWall10.Size = new System.Drawing.Size(228, 162);
            this.picWall10.TabIndex = 11;
            this.picWall10.TabStop = false;
            // 
            // picWall0
            // 
            this.picWall0.BackColor = System.Drawing.Color.Transparent;
            this.picWall0.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall0.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall0.Location = new System.Drawing.Point(2, 1);
            this.picWall0.Name = "picWall0";
            this.picWall0.Size = new System.Drawing.Size(82, 388);
            this.picWall0.TabIndex = 12;
            this.picWall0.TabStop = false;
            // 
            // picWall7
            // 
            this.picWall7.BackColor = System.Drawing.Color.Transparent;
            this.picWall7.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall7.Location = new System.Drawing.Point(714, 656);
            this.picWall7.Name = "picWall7";
            this.picWall7.Size = new System.Drawing.Size(380, 67);
            this.picWall7.TabIndex = 14;
            this.picWall7.TabStop = false;
            // 
            // picWall8
            // 
            this.picWall8.BackColor = System.Drawing.Color.Transparent;
            this.picWall8.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall8.Location = new System.Drawing.Point(1093, 274);
            this.picWall8.Name = "picWall8";
            this.picWall8.Size = new System.Drawing.Size(82, 449);
            this.picWall8.TabIndex = 15;
            this.picWall8.TabStop = false;
            // 
            // picWall1
            // 
            this.picWall1.BackColor = System.Drawing.Color.Transparent;
            this.picWall1.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall1.Location = new System.Drawing.Point(83, 1);
            this.picWall1.Name = "picWall1";
            this.picWall1.Size = new System.Drawing.Size(469, 67);
            this.picWall1.TabIndex = 13;
            this.picWall1.TabStop = false;
            // 
            // picWall2
            // 
            this.picWall2.BackColor = System.Drawing.Color.Transparent;
            this.picWall2.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall2.Location = new System.Drawing.Point(551, 1);
            this.picWall2.Name = "picWall2";
            this.picWall2.Size = new System.Drawing.Size(469, 67);
            this.picWall2.TabIndex = 16;
            this.picWall2.TabStop = false;
            // 
            // picWall11
            // 
            this.picWall11.BackColor = System.Drawing.Color.Transparent;
            this.picWall11.BackgroundImage = global::Fall2020_CSC403_Project.Properties.Resources.wall;
            this.picWall11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picWall11.Location = new System.Drawing.Point(551, 425);
            this.picWall11.Name = "picWall11";
            this.picWall11.Size = new System.Drawing.Size(164, 232);
            this.picWall11.TabIndex = 17;
            this.picWall11.TabStop = false;
            // 
            // winImage
            // 
            this.winImage.Image = ((System.Drawing.Image)(resources.GetObject("winImage.Image")));
            this.winImage.Location = new System.Drawing.Point(377, 210);
            this.winImage.Name = "winImage";
            this.winImage.Size = new System.Drawing.Size(438, 300);
            this.winImage.TabIndex = 19;
            this.winImage.TabStop = false;
            this.winImage.Visible = false;
            // 
            // checkWin
            // 
            this.checkWin.Enabled = true;
            this.checkWin.Tick += new System.EventHandler(this.winChecker);
            //
            // checkLose
            //
            this.checkLose.Enabled = true;
            this.checkLose.Tick += new System.EventHandler(this.LoseChecker);
            // 
            // lblPlayerHealthFull
            // 
            this.lblPlayerHealthFull.BackColor = System.Drawing.Color.Blue;
            this.lblPlayerHealthFull.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerHealthFull.ForeColor = System.Drawing.Color.White;
            this.lblPlayerHealthFull.Location = new System.Drawing.Point(165, 9);
            this.lblPlayerHealthFull.Name = "lblPlayerHealthFull";
            this.lblPlayerHealthFull.Size = new System.Drawing.Size(226, 20);
            this.lblPlayerHealthFull.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(164, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 23);
            this.label1.TabIndex = 19;
            // 
            // cheatMenu
            // 
            this.cheatMenu.BackColor = System.Drawing.Color.Black;
            this.cheatMenu.Controls.Add(this.cheatMenuDefenseDisplay);
            this.cheatMenu.Controls.Add(this.cheatMenuEvasionDisplay);
            this.cheatMenu.Controls.Add(this.cheatMenuHealthDisplay);
            this.cheatMenu.Controls.Add(this.cheatMenuSpeedDisplay);
            this.cheatMenu.Controls.Add(this.label2);
            this.cheatMenu.Controls.Add(this.cheatMenuDefenseUpButton);
            this.cheatMenu.Controls.Add(this.cheatMenuEvasionUpButton);
            this.cheatMenu.Controls.Add(this.cheatMenuHealthUpButton);
            this.cheatMenu.Controls.Add(this.cheatMenuSpeedUpButton);
            this.cheatMenu.Controls.Add(this.cheatMenuDefenseLabel);
            this.cheatMenu.Controls.Add(this.cheatMenuEvasionLabel);
            this.cheatMenu.Controls.Add(this.cheatMenuHealthLabel);
            this.cheatMenu.Controls.Add(this.cheatMenuSpeedLabel);
            this.cheatMenu.Controls.Add(this.cheatMenuDefenseDownButton);
            this.cheatMenu.Controls.Add(this.cheatMenuEvasionDownButton);
            this.cheatMenu.Controls.Add(this.cheatMenuHealthDownButton);
            this.cheatMenu.Controls.Add(this.cheatMenuSpeedDownButton);
            this.cheatMenu.Controls.Add(this.cheatMenuWinButton);
            this.cheatMenu.Controls.Add(this.cheatMenuPictureBox);
            this.cheatMenu.Controls.Add(this.cheatMenuExitButton);
            this.cheatMenu.Location = new System.Drawing.Point(377, 210);
            this.cheatMenu.Name = "cheatMenu";
            this.cheatMenu.Size = new System.Drawing.Size(438, 300);
            this.cheatMenu.TabIndex = 21;
            this.cheatMenu.Visible = false;
            // 
            // cheatMenuDefenseDisplay
            // 
            this.cheatMenuDefenseDisplay.AutoSize = true;
            this.cheatMenuDefenseDisplay.BackColor = System.Drawing.Color.White;
            this.cheatMenuDefenseDisplay.Location = new System.Drawing.Point(174, 205);
            this.cheatMenuDefenseDisplay.MinimumSize = new System.Drawing.Size(77, 16);
            this.cheatMenuDefenseDisplay.Name = "cheatMenuDefenseDisplay";
            this.cheatMenuDefenseDisplay.Size = new System.Drawing.Size(77, 16);
            this.cheatMenuDefenseDisplay.TabIndex = 28;
            this.cheatMenuDefenseDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cheatMenuEvasionDisplay
            // 
            this.cheatMenuEvasionDisplay.AutoSize = true;
            this.cheatMenuEvasionDisplay.BackColor = System.Drawing.Color.White;
            this.cheatMenuEvasionDisplay.Location = new System.Drawing.Point(174, 162);
            this.cheatMenuEvasionDisplay.MinimumSize = new System.Drawing.Size(77, 16);
            this.cheatMenuEvasionDisplay.Name = "cheatMenuEvasionDisplay";
            this.cheatMenuEvasionDisplay.Size = new System.Drawing.Size(77, 16);
            this.cheatMenuEvasionDisplay.TabIndex = 27;
            this.cheatMenuEvasionDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cheatMenuHealthDisplay
            // 
            this.cheatMenuHealthDisplay.AutoSize = true;
            this.cheatMenuHealthDisplay.BackColor = System.Drawing.Color.White;
            this.cheatMenuHealthDisplay.Location = new System.Drawing.Point(174, 122);
            this.cheatMenuHealthDisplay.MinimumSize = new System.Drawing.Size(77, 16);
            this.cheatMenuHealthDisplay.Name = "cheatMenuHealthDisplay";
            this.cheatMenuHealthDisplay.Size = new System.Drawing.Size(77, 16);
            this.cheatMenuHealthDisplay.TabIndex = 26;
            this.cheatMenuHealthDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cheatMenuSpeedDisplay
            // 
            this.cheatMenuSpeedDisplay.AutoSize = true;
            this.cheatMenuSpeedDisplay.BackColor = System.Drawing.Color.White;
            this.cheatMenuSpeedDisplay.Location = new System.Drawing.Point(174, 82);
            this.cheatMenuSpeedDisplay.MinimumSize = new System.Drawing.Size(77, 16);
            this.cheatMenuSpeedDisplay.Name = "cheatMenuSpeedDisplay";
            this.cheatMenuSpeedDisplay.Size = new System.Drawing.Size(77, 16);
            this.cheatMenuSpeedDisplay.TabIndex = 25;
            this.cheatMenuSpeedDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Fugaz One", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(144, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 31);
            this.label2.TabIndex = 24;
            this.label2.Text = "CHEAT MENU";
            // 
            // cheatMenuDefenseUpButton
            // 
            this.cheatMenuDefenseUpButton.Location = new System.Drawing.Point(251, 203);
            this.cheatMenuDefenseUpButton.Name = "cheatMenuDefenseUpButton";
            this.cheatMenuDefenseUpButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuDefenseUpButton.TabIndex = 23;
            this.cheatMenuDefenseUpButton.Text = "+";
            this.cheatMenuDefenseUpButton.UseVisualStyleBackColor = true;
            this.cheatMenuDefenseUpButton.Click += new System.EventHandler(this.cheatMenuDefenseUpButton_Click);
            // 
            // cheatMenuEvasionUpButton
            // 
            this.cheatMenuEvasionUpButton.Location = new System.Drawing.Point(251, 160);
            this.cheatMenuEvasionUpButton.Name = "cheatMenuEvasionUpButton";
            this.cheatMenuEvasionUpButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuEvasionUpButton.TabIndex = 22;
            this.cheatMenuEvasionUpButton.Text = "+";
            this.cheatMenuEvasionUpButton.UseVisualStyleBackColor = true;
            this.cheatMenuEvasionUpButton.Click += new System.EventHandler(this.cheatMenuEvasionUpButton_Click);
            // 
            // cheatMenuHealthUpButton
            // 
            this.cheatMenuHealthUpButton.Location = new System.Drawing.Point(251, 120);
            this.cheatMenuHealthUpButton.Name = "cheatMenuHealthUpButton";
            this.cheatMenuHealthUpButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuHealthUpButton.TabIndex = 21;
            this.cheatMenuHealthUpButton.Text = "+";
            this.cheatMenuHealthUpButton.UseVisualStyleBackColor = true;
            this.cheatMenuHealthUpButton.Click += new System.EventHandler(this.cheatMenuHealthUpButton_Click);
            // 
            // cheatMenuSpeedUpButton
            // 
            this.cheatMenuSpeedUpButton.Location = new System.Drawing.Point(251, 80);
            this.cheatMenuSpeedUpButton.Name = "cheatMenuSpeedUpButton";
            this.cheatMenuSpeedUpButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuSpeedUpButton.TabIndex = 20;
            this.cheatMenuSpeedUpButton.Text = "+";
            this.cheatMenuSpeedUpButton.UseVisualStyleBackColor = true;
            this.cheatMenuSpeedUpButton.Click += new System.EventHandler(this.cheatMenuSpeedUpButton_Click);
            // 
            // cheatMenuDefenseLabel
            // 
            this.cheatMenuDefenseLabel.AutoSize = true;
            this.cheatMenuDefenseLabel.BackColor = System.Drawing.Color.Transparent;
            this.cheatMenuDefenseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMenuDefenseLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.cheatMenuDefenseLabel.Location = new System.Drawing.Point(44, 203);
            this.cheatMenuDefenseLabel.Name = "cheatMenuDefenseLabel";
            this.cheatMenuDefenseLabel.Size = new System.Drawing.Size(108, 18);
            this.cheatMenuDefenseLabel.TabIndex = 19;
            this.cheatMenuDefenseLabel.Text = "Player Defense";
            // 
            // cheatMenuEvasionLabel
            // 
            this.cheatMenuEvasionLabel.AutoSize = true;
            this.cheatMenuEvasionLabel.BackColor = System.Drawing.Color.Transparent;
            this.cheatMenuEvasionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMenuEvasionLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.cheatMenuEvasionLabel.Location = new System.Drawing.Point(44, 162);
            this.cheatMenuEvasionLabel.Name = "cheatMenuEvasionLabel";
            this.cheatMenuEvasionLabel.Size = new System.Drawing.Size(106, 18);
            this.cheatMenuEvasionLabel.TabIndex = 18;
            this.cheatMenuEvasionLabel.Text = "Player Evasion";
            // 
            // cheatMenuHealthLabel
            // 
            this.cheatMenuHealthLabel.AutoSize = true;
            this.cheatMenuHealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.cheatMenuHealthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMenuHealthLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.cheatMenuHealthLabel.Location = new System.Drawing.Point(44, 122);
            this.cheatMenuHealthLabel.Name = "cheatMenuHealthLabel";
            this.cheatMenuHealthLabel.Size = new System.Drawing.Size(95, 18);
            this.cheatMenuHealthLabel.TabIndex = 17;
            this.cheatMenuHealthLabel.Text = "Player Health";
            // 
            // cheatMenuSpeedLabel
            // 
            this.cheatMenuSpeedLabel.AutoSize = true;
            this.cheatMenuSpeedLabel.BackColor = System.Drawing.Color.Transparent;
            this.cheatMenuSpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cheatMenuSpeedLabel.ForeColor = System.Drawing.SystemColors.Window;
            this.cheatMenuSpeedLabel.Location = new System.Drawing.Point(44, 79);
            this.cheatMenuSpeedLabel.Name = "cheatMenuSpeedLabel";
            this.cheatMenuSpeedLabel.Size = new System.Drawing.Size(95, 18);
            this.cheatMenuSpeedLabel.TabIndex = 16;
            this.cheatMenuSpeedLabel.Text = "Player Speed";
            // 
            // cheatMenuDefenseDownButton
            // 
            this.cheatMenuDefenseDownButton.Location = new System.Drawing.Point(154, 203);
            this.cheatMenuDefenseDownButton.Name = "cheatMenuDefenseDownButton";
            this.cheatMenuDefenseDownButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuDefenseDownButton.TabIndex = 15;
            this.cheatMenuDefenseDownButton.Text = "-";
            this.cheatMenuDefenseDownButton.UseVisualStyleBackColor = true;
            this.cheatMenuDefenseDownButton.Click += new System.EventHandler(this.cheatMenuDefenseDownButton_Click);
            // 
            // cheatMenuEvasionDownButton
            // 
            this.cheatMenuEvasionDownButton.Location = new System.Drawing.Point(154, 160);
            this.cheatMenuEvasionDownButton.Name = "cheatMenuEvasionDownButton";
            this.cheatMenuEvasionDownButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuEvasionDownButton.TabIndex = 14;
            this.cheatMenuEvasionDownButton.Text = "-";
            this.cheatMenuEvasionDownButton.UseVisualStyleBackColor = true;
            this.cheatMenuEvasionDownButton.Click += new System.EventHandler(this.cheatMenuEvasionDownButton_Click);
            // 
            // cheatMenuHealthDownButton
            // 
            this.cheatMenuHealthDownButton.Location = new System.Drawing.Point(154, 120);
            this.cheatMenuHealthDownButton.Name = "cheatMenuHealthDownButton";
            this.cheatMenuHealthDownButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuHealthDownButton.TabIndex = 13;
            this.cheatMenuHealthDownButton.Text = "-";
            this.cheatMenuHealthDownButton.UseVisualStyleBackColor = true;
            this.cheatMenuHealthDownButton.Click += new System.EventHandler(this.cheatMenuHealthDownButton_Click);
            // 
            // cheatMenuSpeedDownButton
            // 
            this.cheatMenuSpeedDownButton.Location = new System.Drawing.Point(154, 80);
            this.cheatMenuSpeedDownButton.Name = "cheatMenuSpeedDownButton";
            this.cheatMenuSpeedDownButton.Size = new System.Drawing.Size(20, 20);
            this.cheatMenuSpeedDownButton.TabIndex = 12;
            this.cheatMenuSpeedDownButton.Text = "-";
            this.cheatMenuSpeedDownButton.UseVisualStyleBackColor = true;
            this.cheatMenuSpeedDownButton.Click += new System.EventHandler(this.cheatMenuSpeedDownButton_Click);
            // 
            // cheatMenuWinButton
            // 
            this.cheatMenuWinButton.Location = new System.Drawing.Point(39, 255);
            this.cheatMenuWinButton.Name = "cheatMenuWinButton";
            this.cheatMenuWinButton.Size = new System.Drawing.Size(75, 23);
            this.cheatMenuWinButton.TabIndex = 11;
            this.cheatMenuWinButton.Text = "WIN GAME";
            this.cheatMenuWinButton.UseVisualStyleBackColor = true;
            this.cheatMenuWinButton.Click += new System.EventHandler(this.cheatMenuWinButton_Click);
            // 
            // cheatMenuPictureBox
            // 
            this.cheatMenuPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("cheatMenuPictureBox.Image")));
            this.cheatMenuPictureBox.Location = new System.Drawing.Point(288, 47);
            this.cheatMenuPictureBox.Name = "cheatMenuPictureBox";
            this.cheatMenuPictureBox.Size = new System.Drawing.Size(147, 267);
            this.cheatMenuPictureBox.TabIndex = 10;
            this.cheatMenuPictureBox.TabStop = false;
            // 
            // cheatMenuExitButton
            // 
            this.cheatMenuExitButton.Location = new System.Drawing.Point(360, 3);
            this.cheatMenuExitButton.Name = "cheatMenuExitButton";
            this.cheatMenuExitButton.Size = new System.Drawing.Size(75, 23);
            this.cheatMenuExitButton.TabIndex = 9;
            this.cheatMenuExitButton.Text = "Close";
            this.cheatMenuExitButton.UseVisualStyleBackColor = true;
            this.cheatMenuExitButton.Click += new System.EventHandler(this.closeCheatMenu);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(488, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Press \'X\' to open cheat menu";
            // 
            // cheatMenuUpdater
            // 
            this.cheatMenuUpdater.Enabled = true;
            this.cheatMenuUpdater.Tick += new System.EventHandler(this.cheatMenuUpdater_tick);
            // 
            // FrmLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1176, 726);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cheatMenu);
            this.Controls.Add(this.winImage);
            this.Controls.Add(this.lblPlayerHealthFull);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picWall11);
            this.Controls.Add(this.picWall2);
            this.Controls.Add(this.picWall8);
            this.Controls.Add(this.picWall7);
            this.Controls.Add(this.lblInGameTime);
            this.Controls.Add(this.picWall1);
            this.Controls.Add(this.picWall0);
            this.Controls.Add(this.picWall10);
            this.Controls.Add(this.picWall9);
            this.Controls.Add(this.picWall6);
            this.Controls.Add(this.picWall12);
            this.Controls.Add(this.picWall4);
            this.Controls.Add(this.picWall5);
            this.Controls.Add(this.picEnemyCheeto);
            this.Controls.Add(this.picEnemyPoisonPacket);
            this.Controls.Add(this.picWall3);
            this.Controls.Add(this.picBossKoolAid);
            this.Controls.Add(this.picPlayer);
            this.DoubleBuffered = true;
            this.Name = "FrmLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Explore";
            this.Load += new System.EventHandler(this.FrmLevel_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FrmLevel_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyCheeto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEnemyPoisonPacket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBossKoolAid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWall11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winImage)).EndInit();
            this.cheatMenu.ResumeLayout(false);
            this.cheatMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cheatMenuPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

    }


    #endregion

    private System.Windows.Forms.PictureBox picPlayer;
    private System.Windows.Forms.PictureBox picBossKoolAid;
    private System.Windows.Forms.Label lblInGameTime;
    private System.Windows.Forms.Timer tmrUpdateInGameTime;
    private System.Windows.Forms.Timer tmrEnemyMove;
    private System.Windows.Forms.Timer tmrPlayerMove;
    private System.Windows.Forms.PictureBox picWall3;
    private System.Windows.Forms.PictureBox picEnemyPoisonPacket;
    private System.Windows.Forms.PictureBox picEnemyCheeto;
    private System.Windows.Forms.PictureBox picWall5;
    private System.Windows.Forms.PictureBox picWall4;
    private System.Windows.Forms.PictureBox picWall12;
    private System.Windows.Forms.PictureBox picWall6;
    private System.Windows.Forms.PictureBox picWall9;
    private System.Windows.Forms.PictureBox picWall10;
    private System.Windows.Forms.PictureBox picWall0;
    private System.Windows.Forms.PictureBox picWall7;
    private System.Windows.Forms.PictureBox picWall8;
    private System.Windows.Forms.PictureBox picWall1;
    private System.Windows.Forms.PictureBox picWall2;
    private System.Windows.Forms.PictureBox picWall11;
        private System.Windows.Forms.PictureBox winImage;
        private System.Windows.Forms.Timer checkWin;
        private System.Windows.Forms.Timer checkLose;
        private System.Windows.Forms.Label lblPlayerHealthFull;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel cheatMenu;
        private System.Windows.Forms.Button cheatMenuDefenseDownButton;
        private System.Windows.Forms.Button cheatMenuEvasionDownButton;
        private System.Windows.Forms.Button cheatMenuHealthDownButton;
        private System.Windows.Forms.Button cheatMenuSpeedDownButton;
        private System.Windows.Forms.Button cheatMenuWinButton;
        private System.Windows.Forms.PictureBox cheatMenuPictureBox;
        private System.Windows.Forms.Button cheatMenuExitButton;
        private System.Windows.Forms.Label cheatMenuDefenseLabel;
        private System.Windows.Forms.Label cheatMenuEvasionLabel;
        private System.Windows.Forms.Label cheatMenuHealthLabel;
        private System.Windows.Forms.Label cheatMenuSpeedLabel;
        private System.Windows.Forms.Button cheatMenuDefenseUpButton;
        private System.Windows.Forms.Button cheatMenuEvasionUpButton;
        private System.Windows.Forms.Button cheatMenuHealthUpButton;
        private System.Windows.Forms.Button cheatMenuSpeedUpButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cheatMenuSpeedDisplay;
        private System.Windows.Forms.Label cheatMenuHealthDisplay;
        private System.Windows.Forms.Label cheatMenuEvasionDisplay;
        private System.Windows.Forms.Label cheatMenuDefenseDisplay;
        private System.Windows.Forms.Timer cheatMenuUpdater;
    }
}

