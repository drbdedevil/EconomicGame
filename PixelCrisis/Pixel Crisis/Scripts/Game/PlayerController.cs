using Godot;
using System;
using System.Data;
using System.Runtime.CompilerServices;

public class PlayerController : Node
{
    [Export]
    private int _mana { get; set; }

    [Export]
    private int _manaRecovery { get; set; }

    // private _currentSpell {get; set;}


    public override void _Ready()
    {

    }

    public override void _Process(float delta)
    {
        base._Process(delta);
    }

    public void UpdateStage()
    {
        _mana += _manaRecovery;
    }

    public void CastSpell()
    {
        
    }
}
