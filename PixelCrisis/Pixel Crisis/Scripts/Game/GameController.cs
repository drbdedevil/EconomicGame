using Godot;
using System;


public enum GameResult
{
    GR_WIN,
    GR_LOSE
}

public class GameController : Node2D
{


    [Export]
    private int _stageDuration { get; set; }

    private PlayerController _playerController { get; }
    private TownController _townController { get; }

    [Export]
    private NodePath PlayerControllerNode;

    [Export]
    private NodePath TownControllerNode;


    [Signal]
    public delegate void GameEnd(GameResult result);

    public override void _Ready()
    {
        if (PlayerControllerNode == null)
        {
            GD.PrintErr("GameController.cs: Playercontroller node is`t setted!");
        }

        if (TownControllerNode == null)
        {
            GD.PrintErr("GameController.cs: TownController node is`t setted!");
        }
    }

    public override void _Process(float delta)
    {
        base._Process(delta);
    }
    
    public void UpdateStage()
    {

    }
}
