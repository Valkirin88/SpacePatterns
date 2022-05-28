using UnityEngine;

namespace SpacePatterns
{
    internal sealed class PlayerHealth : MonoBehaviour
    {
        [SerializeField] private float _hp = 10;
        private void OnCollisionEnter2D(Collision2D collision)
        {
            if (_hp <= 0)
            {
                Destroy(gameObject);
            }
            else
            {
                _hp--;
            }
        }
    }
}
