using Godot;
using System;

public abstract class AbstractBuilding : Node2D
{
    [Export]
    protected Sprite _defaultSprite;
    
    [Export]
    protected Sprite _destroyedSprite;

    [Export]
    protected int _capacityResidents = 0;

    [Export]
    protected float _health = 1.0f; 

    [Export]
    protected float repairStrenght = 1.0f;


    public override void _Ready()
    {
        base._Ready();
    }


    public virtual void startProcess() { }

    public virtual void process() { }

    public virtual void endProcess() { }

    public virtual void repair() { }
}
