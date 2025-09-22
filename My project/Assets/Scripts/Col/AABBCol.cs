using UnityEngine;

public class AABBCol : ColBase
{
    public Vector3 size = Vector3.one;

    public Vector3 Min => transform.position - size * 0.5f;
    public Vector3 Max => transform.position + size * 0.5f;

    public override bool IsColliding(ColBase other)
    {
        if (other is AABBCol aabb)
        {
            return CheckAABB(this, aabb);
        }
        else if (other is SphereCol sphere)
        {
            return sphere.IsColliding(this);
        }

        return false;
    }

    private bool CheckAABB(AABBCol a, AABBCol b)
    {
        return (a.Min.x <= b.Max.x && a.Max.x >= b.Min.x) &&
               (a.Min.y <= b.Max.y && a.Max.y >= b.Min.y) &&
               (a.Min.z <= b.Max.z && a.Max.z >= b.Min.z);
    }
}
