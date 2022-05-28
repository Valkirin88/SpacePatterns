using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SpacePatterns
{
    internal sealed class Laser : Weapon
    {
       
        public Laser(Rigidbody weapon, Transform barrel, float force) : base(weapon, barrel, force)
        {

        }
    }
}
