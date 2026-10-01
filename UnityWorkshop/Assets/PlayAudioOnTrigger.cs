using UnityEngine;

public class PlayAudioOnTrigger : MonoBehaviour
{

    public AudioClip winSFX;

    private void OnTriggerEnter(Collider other)
    {
        // check if ball
        if (other.gameObject.name == "Sphere(Clone)")
        {
            Debug.Log("Yay!");
            GetComponent<AudioSource>().PlayOneShot(winSFX);
        }
        // play audio
    }
}
