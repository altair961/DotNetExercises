﻿namespace DemoCode
{
    public class Calculator
    {
        public int Value { get; private set; }

        public void Substract(int number)
        {
            Value -= number;
        }

        public void Add(int number)
        {
            Value += number;
        }
    }
}
