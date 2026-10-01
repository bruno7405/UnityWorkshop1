using UnityEngine;

public class DestroyOnTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Name of object dying: " + other.gameObject.name);
        Destroy(other.gameObject);
    }
}
