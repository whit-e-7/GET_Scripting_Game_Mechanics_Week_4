using UnityEngine;

public class GET_Collision : MonoBehaviour
{
    // This will be called when another collider enters this object's trigger.
    void OnTriggerEnter(Collider other)
    {
        // If the object that collided with this object has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Destroy the object with the "TriggerObject" tag when the player enters its trigger
            Destroy(gameObject);

            // Show trigger feedback in Console Window
            print("Player Entered Trigger and TriggerObject Destroyed");
        }
    }

    // This will be called when another collider stays inside this object's trigger.
    void OnTriggerStay(Collider other)
    {
        // If the object that stayed in this trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Optionally, add more behavior here while the player is inside the trigger
            print("Player Staying in Trigger");
        }
    }

    // This will be called when another collider exits this object's trigger.
    void OnTriggerExit(Collider other)
    {
        // If the object that exited the trigger has the "Player" tag
        if (other.CompareTag("Player"))
        {
            // Optionally, destroy the object if needed
            // Destroy(gameObject);

            // Show trigger feedback in Console Window
            print("Player Exited Trigger");
        }
    }
}
