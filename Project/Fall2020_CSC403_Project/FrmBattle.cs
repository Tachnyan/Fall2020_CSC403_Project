using Fall2020_CSC403_Project.code;
using Fall2020_CSC403_Project.Properties;
using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace Fall2020_CSC403_Project {
  public partial class FrmBattle : ChildForm {
    private bool bossBattle = false;
    public static FrmBattle instance = null;
    private Enemy enemy;
    private Player player;
    public SoundPlayer battleMusic = new SoundPlayer(Resources.battle_music);
    public SoundPlayer mapMusic = new SoundPlayer(Resources.map_music);

    private FrmBattle() {
            

      InitializeComponent();
      player = Game.player;
    }


    public void Setup() {
      // update for this enemy
      picEnemy.BackgroundImage = enemy.Img;
      picEnemy.Refresh();
      BackColor = enemy.Color;
      picBossBattle.Visible = false;

      // Observer pattern
      enemy.AttackEvent += PlayerDamage;
      player.AttackEvent += EnemyDamage;

      // show health
      UpdateHealthBars();
    }

    public void SetupForBossBattle() {
      picBossBattle.Location = Point.Empty;
      picBossBattle.Size = ClientSize;
      picBossBattle.Visible = true;

      SoundPlayer simpleSound = new SoundPlayer(Resources.battle_music2);
      simpleSound.Play();
      
      tmrFinalBattle.Enabled = true;
      bossBattle = true;
    }

    public static FrmBattle GetInstance(Enemy enemy) {
      if (instance == null) {
        instance = new FrmBattle();
        instance.enemy = enemy;
        instance.Setup();
      }
      return instance;
    }

    private void UpdateHealthBars() {
      float playerHealthPer = player.Health / (float)player.MaxHealth;
      float enemyHealthPer = enemy.Health / (float)enemy.MaxHealth;

      const int MAX_HEALTHBAR_WIDTH = 226;
      lblPlayerHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * playerHealthPer);
      lblEnemyHealthFull.Width = (int)(MAX_HEALTHBAR_WIDTH * enemyHealthPer);

      lblPlayerHealthFull.Text = player.Health.ToString();
      lblEnemyHealthFull.Text = enemy.Health.ToString();
    }

    private void btnAttack_Click(object sender, EventArgs e) {
      player.OnAttack(-4);
      if (enemy.Health > 0) {
        enemy.OnAttack(-2);
      }

      UpdateHealthBars();
        
      if (bossBattle & enemy.Health <= 0)
      {
        FrmLevel.win = true;
      }
      if (player.Health <= 0 || enemy.Health <= 0) {
        instance = null;
        CloseCleanly();
      }
    }

    private void EnemyDamage(int amount) {
      enemy.AlterHealth(amount);
    }

    private void PlayerDamage(int amount) {
      player.AlterHealth(amount);
    }

    private void tmrFinalBattle_Tick(object sender, EventArgs e) {
      picBossBattle.Visible = false;
      tmrFinalBattle.Enabled = false;
    }
  }
}
