using UnityEngine;

public interface IMovable
{
    /// <summary>
    /// Moves with the specified mouse vector.
    /// </summary>
    /// <param name="mouseVector">The mouse vector.</param>
    /// <param name="player">The player.</param>
    void Move(Vector2 mouseVector, GameObject player);
}
