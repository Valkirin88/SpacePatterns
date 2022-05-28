using UnityEngine;

internal class MoveEnemies 
{
   private float _moveSpace = 2f;
   public void MoveEnemiesRandomly(Transform transform)
    {
        transform.Translate( new Vector3(Random.Range(-_moveSpace, _moveSpace), Random.Range(-_moveSpace, _moveSpace), 0));
    }
}
