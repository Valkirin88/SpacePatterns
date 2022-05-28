using UnityEngine;

namespace SpacePatterns
{
    internal sealed class Bullet : Weapon
    {
        
        public Bullet(Rigidbody weapon, Transform barrel, float force) : base(weapon, barrel, force)
        {

        }

    }
}
