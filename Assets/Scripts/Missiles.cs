 using UnityEngine;

namespace SpacePatterns
{
  
    internal sealed class Missiles : Weapon
    {
        [SerializeField] private Sprite _sprite;
        private WeaponMover _weaponMover;

        public Missiles(Rigidbody weapon, Transform barrel, float force) : base(weapon, barrel, force)
        {
            
        }

        public void CreateAndMoveMissiles()
        {
            var missile = new GameObject().SetName("missile").AddBoxCollider2D().AddRigidBody2D(5.0f).AddSprite(_sprite);
            missile.transform.position = _barrel.position;
            _weaponMover = new WeaponMover(missile);
        }
    }
}
