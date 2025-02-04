﻿using System.Drawing;
using System;

namespace Fall2020_CSC403_Project.code {
  /// <summary>
  /// This is the class for an enemy
  /// </summary>
  public class Enemy : BattleCharacter {
    /// <summary>
    /// THis is the image for an enemy
    /// </summary>
    public Image Img { get; set; }

    /// <summary>
    /// this is the background color for the fight form for this enemy
    /// </summary>
    public Color Color { get; set; }

    /// <summary>
    /// this is the difficulty for selecting enemy attributes
    /// </summary>

    private int difficulty;

    /// <param name="initPos">this is the initial position of the enemy</param>
    /// <param name="collider">this is the collider for the enemy</param>
    /// <param name="strength">this is the enemy strength</param>
    /// <param name="evasion">this is the enemy evasion</param>
    /// <param name="defense">this is the enemy defense</param>
    public Enemy(Vector2 initPos, Collider collider, float strength, float evasion, float defense) : base(initPos, collider, strength, evasion, defense) {
      difficulty = Game.difficulty;
      if(difficulty == 0){
        MaxHealth = 20;
        this.strength = strength;
        this.evasion = evasion;
        this.defense = defense;
        Health = MaxHealth;
      }
      if(difficulty == 1){
          MaxHealth = 30;
          this.strength = 3;
          this.evasion = 3;
          this.defense = 3;
          Health = MaxHealth;
      }
      if(difficulty == 2){
          MaxHealth = 40;
          this.strength = 4;
          this.evasion = 4;
          this.defense = 4;
          Health = MaxHealth;
      }

            enemyPosition = initPos;
            enemyCollider = collider;
    }

    public Vector2 enemyMoveSpeed { get; private set; }
    private Direction currentDirection;
    public Vector2 enemyLastPosition { get; private set; }
    public Vector2 enemyPosition { get; private set; }
    public Collider enemyCollider { get; private set; }

    public void EnemyMove()
    {
       enemyLastPosition = enemyPosition;
       enemyPosition = new Vector2(enemyPosition.x + enemyMoveSpeed.x, enemyPosition.y + enemyMoveSpeed.y);
       enemyCollider.MovePosition((int)enemyPosition.x, (int)enemyPosition.y);
     }
     public void EnemyGoLeft()
     {
            enemyMoveSpeed = new Vector2(-2, 0);
            currentDirection = Direction.Left;
     }

    public void EnemyGoDown()
        {
            enemyMoveSpeed = new Vector2(0, +2);
            currentDirection = Direction.Down;
        }

    public void EnemyGoUp()
        {
            enemyMoveSpeed = new Vector2(0, -2);
            currentDirection = Direction.Up;
        }

    public void EnemyGoRight()
        {
            enemyMoveSpeed = new Vector2(+2, 0);
            currentDirection = Direction.Right;
        }

    public void EnemyMoveBack()
        {
            enemyPosition = enemyLastPosition;
        }

        private enum Direction : int
        {
            Left = 0,
            Up = 1,
            Right = 2,
            Down = 3
        }
        public void RandomDirection()
        {


            int Dir = Util.rand.Next(0, 4);

            if(Dir == (int)Direction.Left)
            {
                if ((int)currentDirection == Dir) EnemyGoRight();
                else EnemyGoLeft();
            }
            else if(Dir == (int)Direction.Right)
            {
                if ((int)currentDirection == Dir) EnemyGoLeft();
                else EnemyGoRight();
            }
            else if(Dir == (int)Direction.Down)
            {
                if ((int)currentDirection == Dir) EnemyGoUp();
                else EnemyGoDown();
            }
            else if(Dir == (int)Direction.Up)
            {
                if ((int)currentDirection == Dir) EnemyGoDown();
                else EnemyGoUp();
            }

        }
    }

}
