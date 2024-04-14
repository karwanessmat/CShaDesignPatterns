﻿using State5Demo._1_CreateStateInterface;
using State5Demo._3_ContextClass;

namespace State5Demo._2_ImplementConcreteStates;

public class GreenLight : ITrafficLightState
{
    public void Handle(TrafficLight context)
    {
        Console.WriteLine("Green light - go!");
        context.SetState(new YellowLight());
    }
}