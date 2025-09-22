using UnityEngine;

public class SphereCol : ColBase
{
    public float radius = 1.0f;

    public override bool IsColliding(ColBase other)
    {
        if (other is SphereCol sphere)
        {
            float dist = Vector3.Distance(transform.position, sphere.transform.position);

            return dist < (radius + sphere.radius);
        }
        else if (other is AABBCol aabb)
        {
            return CheckSphereAABB(this, aabb);
        }

        return false;
    }

    private bool CheckSphereAABB(SphereCol sphere, AABBCol aabb)
    {
        Vector3 closest = Vector3.Max(aabb.Min, Vector3.Min(sphere.transform.position, aabb.Max));
        float distSq = (sphere.transform.position - closest).sqrMagnitude;

        return distSq < (sphere.radius * sphere.radius);
    }
}
