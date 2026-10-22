using UnityEngine;

public class pewpew : MonoBehaviour
{
    private int bulletSpeed = 18;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.up * bulletSpeed * Time.deltaTime;
    }
}
