using System;

namespace SpacePatterns
{
    [Serializable]
    internal sealed class Asteroid : Enemy
    {

        public override string ToString()
        {
            return $"Speed {Speed} Health {Health}";
        }
    }
}
