using System;

namespace SpacePatterns
{
    [Serializable]
    internal sealed class EnemyShip : Enemy
    {
        public override string ToString()
        {
            return $"Speed {Speed} Health {Health}";
        }
    }
}