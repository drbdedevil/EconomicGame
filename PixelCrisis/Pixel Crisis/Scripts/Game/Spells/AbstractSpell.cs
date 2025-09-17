using Godot;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Serialization;

public abstract class AbstractSpell : Node2D
{
    [Export]
    protected List<AbstractEffect> _effects;
    public virtual void process() { }
    public override void _Ready() 
    {
    }
}


public abstract class AbstractSpellRegion : AbstractSpell
{
    [Export]
    protected float radius;
    public override void _Ready()
    {

    }
}

public abstract class AbstractSpellSingle
{

}
