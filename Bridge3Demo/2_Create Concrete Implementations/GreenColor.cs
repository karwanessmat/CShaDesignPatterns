﻿using System;
using Bridge3Demo._1_Define_Implementor_Interface;

namespace Bridge3Demo._2_Create_Concrete_Implementations
{
    internal class GreenColor:IColor
    {
        public void Color()
        {
            Console.Write("Green ");
        }
    }
}
