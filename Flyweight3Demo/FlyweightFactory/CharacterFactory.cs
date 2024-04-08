﻿using System.Collections.Generic;
using Flyweight3Demo.ConcreteFlyweight;
using Flyweight3Demo.Flyweight_Abstract;

namespace Flyweight3Demo.FlyweightFactory
{
    internal class CharacterFactory
    {
        private  readonly Dictionary<string,Character> _characters = new();

        public int TotalObjectsCreated => _characters.Count;
        public Character GetCharacter(string key)
        {
            key = key.ToLower().Trim();
            // Uses "lazy initialization"
            Character character = null;
            if (_characters.TryGetValue(key, out var characterValue))
            {
                character = characterValue;
            }
            else
            {
                character = key switch
                {
                    "a" => new CharacterA(),
                    "b" => new CharacterB(),
                    _ => new CharacterZ()
                };
                _characters.Add(key, character);
            }

            return character;
        }
    }
}
