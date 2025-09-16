using Godot;
using System;

public class MainMenu : Control
{
	[Export] private PackedScene _nextScene;
	private Button _playButton;
	private Button _settingsButton;
	public override void _Ready()
	{
		_playButton = GetNode<Button>("CenterContainer/VBoxContainer/BPlay");
		_settingsButton = GetNode<Button>("CenterContainer/VBoxContainer/BSettings");

		_playButton.Connect("pressed", this, nameof(OnPlayPressed));
		_settingsButton.Connect("pressed", this, nameof(OnSettingsPressed));
	}

	private void OnPlayPressed()
	{
		if (_nextScene != null)
		{
			GetTree().ChangeSceneTo(_nextScene);
		}
		else
		{
			GD.PrintErr("MainMenu.cs: _nextScene is`t setted!");
		}
	
	}

	private void OnSettingsPressed()
	{

	}
}
