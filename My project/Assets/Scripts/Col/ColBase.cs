using UnityEngine;

public abstract class ColBase : MonoBehaviour
{
    public abstract bool IsColliding(ColBase other);
}
