using UnityEngine;

namespace SpacePatterns
{
    internal sealed class Health
    {
        public float Max { get; }
        public float Current { get; private set; }

        public Health(float max, float current)
        {
            Max = max;
            Current = current;
        }

        public override string ToString()
        {
            return $"MaxHP {Max} CurrentHP {Current}";
        }

        public void ChangeCurrentHealth(float hp)
        {
            Current = hp;
        }
    }
}