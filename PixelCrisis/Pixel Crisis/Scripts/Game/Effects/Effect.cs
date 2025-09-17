using Godot;
using System;
using System.Diagnostics.PerformanceData;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;



public abstract class AbstractEffect : Node
{
    [Export]
    public int StageDutation;
    public bool IsFinished { get; protected set; }
    public abstract void Apply(Node owner);
}

public class FireEffect
{
    [Export]
    public float _damagePerStage;
}

public class LazyEffect
{
    [Export]
    public float _lazyCoefPerStage;
}

public class SadEffect
{
    [Export]
    public float _sadCoefPerStage; 
}