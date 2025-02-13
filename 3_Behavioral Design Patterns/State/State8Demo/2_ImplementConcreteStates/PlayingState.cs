﻿using State8Demo._1_CreateStateInterface;

namespace State8Demo._2_ImplementConcreteStates;

// the current state is played
public class PlayingState : PlayerState
{
    public override void Play()
    {
        Console.WriteLine("Video is already playing.");
    }

    public override void Pause()
    {
        Console.WriteLine("Pausing video.");
        Player.TransitionTo(new PausedState());
    }

    public override void Stop()
    {
        Console.WriteLine("Stopping video.");
        Player.TransitionTo(new StoppedState());
    }
}