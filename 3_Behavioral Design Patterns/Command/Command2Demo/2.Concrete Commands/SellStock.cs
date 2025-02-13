﻿using Command2Demo._1.Command_Interface;
using Command2Demo._3.Receiver;

namespace Command2Demo._2.Concrete_Commands;

public class SellStock(Stock stock) : IOrder
{
    public void Execute(int value)
    {
        stock.Sell(value);
    }
}