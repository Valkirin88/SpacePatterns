using UnityEngine;

namespace SpacePatterns
{
    [RequireComponent(typeof(Rigidbody))]
    public abstract class Weapon : MonoBehaviour
    {

        protected Rigidbody _weapon;
        protected Transform _barrel;
        protected static float _force;
        public Weapon(Rigidbody weapon, Transform barrel, float force)
        {
            _weapon = weapon;
            _barrel = barrel;
            _force = force;
        }
        public void Shoot()
        {
            Object.Instantiate(_weapon, _barrel.position, _barrel.rotation);
            _weapon.AddForce(Vector3.forward * _force);
        }
    }
}