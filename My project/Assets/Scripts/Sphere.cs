using UnityEngine;

public class Sphere : MonoBehaviour
{
    [Header("スピード"), Range(0.0f, 10.0f)]
    public float speed = 0.0f;

    
    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += transform.forward * Time.deltaTime * speed;
    }
}
