using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform dropPosition;

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Debug.Log("Space key pressed");
            Instantiate(ballPrefab, dropPosition.position + new Vector3(Random.Range(-0.1f, 0.1f), 0, 0), Quaternion.identity);
        }
    }
}
