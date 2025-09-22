using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class ColManager : MonoBehaviour
{
    public List<ColBase> colliders = new List<ColBase>();

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < colliders.Count; i++)
        {
            for (int j = i + 1; j < colliders.Count; j++)
            {
                if (colliders[i].IsColliding(colliders[j]))
                {
                    Debug.Log($"{colliders[i].name}‚Æ{colliders[j].name}‚ª“–‚½‚è‚Ü‚µ‚½");
                }
            }
        }
    }
}
