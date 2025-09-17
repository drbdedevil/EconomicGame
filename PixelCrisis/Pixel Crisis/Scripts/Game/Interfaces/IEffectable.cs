using Godot;
using System;
using System.Collections.Generic;


public interface IEffectable
{
    IList<AbstractEffect> Effects { get; }
    void PushEffect(AbstractEffect effect);
    void ProcessEffects();
    void ClearEffects();
}


