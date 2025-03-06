using UnityEngine;
using UnityEngine.Audio;

public class Footsteps : MonoBehaviour
{
    public AudioSource mFootstepSound;
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.D))
        {
            mFootstepSound.enabled = true;
        }
        else
        {
            mFootstepSound.enabled = false;
        }
    }
}
