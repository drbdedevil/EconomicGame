using Godot;
using System;
using System.Collections.Concurrent;

public class DayStageController : Node2D
{
    private float _stageDurationSec;

    [Export]
    public float StageDurationSec
    {
        get
        {
            return _stageDurationSec;
        }
        set
        {
            _stageDurationSec = value;
            _stageTimer.WaitTime = value;
        }
    } 
    private Timer _stageTimer = new Timer();

    [Export]
    private DayStage _dayStage = DayStage.DS_DAY;

    [Signal]
    public delegate void OnDayStageChange(DayStage dayStage);

    private int _stageCount = 0;

    [Export]
    public int StageCount
    {
        get
        {
            return _stageCount;
        }
        set
        {
            _stageCount = value;
        }
    }

    public override void _Ready()
    {
        AddChild(_stageTimer);
        _stageTimer.Connect("timeout", this, nameof(DayStageTick));
        _stageTimer.OneShot = false;
        _stageTimer.Start();
    }

    public void DayStageTick()
    {
        _dayStage = (_dayStage == DayStage.DS_DAY) ? DayStage.DS_NIGHT : DayStage.DS_DAY;
        EmitSignal(nameof(OnDayStageChange), _dayStage);
        GD.Print(_dayStage);
    }
}
