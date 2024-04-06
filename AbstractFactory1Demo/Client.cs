﻿using AbstractFactory1Demo.Step1_Abstract_Products;
using AbstractFactory1Demo.Step3_Abstract_Factory;

namespace AbstractFactory1Demo
{
    public class Client(IAbstractFactory factory)
    {
        private readonly ProductA _productA = factory.CreateProductA();
        private readonly ProductB _productB = factory.CreateProductB();

        public string Operation()
        {
            var result = $"""
                          ProductA say {_productA.FunctionA()}
                          ProductB say {_productB.FunctionB()}
                          """;

            return result;
        }
    }
}