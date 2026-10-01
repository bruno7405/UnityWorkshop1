using UnityEngine;
using UnityEngine.InputSystem;

public class BallDropper : MonoBehaviour
{
    public GameObject ball;
    public Transform spawnTransform;

    void Start()
    {
        Debug.Log("Start");

    }

    // Update is called once per frame
    void Update()
    {
        // Check for button pressed
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            var spawned = Instantiate(ball);
            spawned.transform.position = spawnTransform.position 
                + new Vector3(Random.Range(-1.5f, 1.5f), Random.Range(-1.5f, 1.5f), 0);
        }


        // Spawn something
    }
}
