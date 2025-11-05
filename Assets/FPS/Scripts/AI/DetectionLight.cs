using Unity.FPS.Game;
using UnityEngine;


public class DetectionLight : MonoBehaviour
{
    public Actor playerInLight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Actor actor = other.GetComponent<Actor>();
            if (actor != null)
            {
                playerInLight = actor;
            }
        }
    }
}
