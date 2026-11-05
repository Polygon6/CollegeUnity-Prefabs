using UnityEngine;

public class shootScript : MonoBehaviour
{
    public GameObject bullet;
    public GameObject originOgject;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0)) {
            Instantiate(bullet, originOgject.transform.position, transform.rotation);
        }
    }
}
