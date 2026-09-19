using UnityEngine;

public class Collectable : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnColliderEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gameObject.SetActive(false);
        }
    }
}
