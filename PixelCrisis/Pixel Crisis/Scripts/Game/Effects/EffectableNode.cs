using Godot;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

public abstract class EffectableNode : Node
{
    private readonly List<AbstractEffect> _effects = new List<AbstractEffect>();

    public IList<AbstractEffect> Effects => _effects;

    public void PushEffect(AbstractEffect effect)
    {
        if (effect == null)
        {
            GD.PrintErr("EffectableNode.cs: Pushed effect is null!");
        }
        _effects.Add(effect);
    }

    public void ProcessEffects()
    {
        foreach (AbstractEffect effect in _effects)
        {
            effect.Apply(this);
        }
    }

    public void ClearEffects()
    {
        _effects.Clear();
    }

}
