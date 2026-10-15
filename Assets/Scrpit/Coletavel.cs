using UnityEngine;

public class Coletavel : MonoBehaviour
{
    private void OnTriggerEnter(Collider outro)
    {
        if (outro.CompareTag("Player"))
        {
            Debug.Log("Coletável pego!");
            Destroy(gameObject);
        }
    }
}