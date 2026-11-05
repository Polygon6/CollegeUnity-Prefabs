using UnityEngine;

public class shootScript : MonoBehaviour
{
    public GameObject bullet;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0)) {
            Instantiate(bullet, new Vector3(8.5f, 2.6f, 0), Quaternion.Euler(0, 0, 90));
        }
    }
}
