using UnityEngine;

public class ResetPosition : MonoBehaviour
{

    public GameObject Slime;
    private Rigidbody rb;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            rb = GetComponent<Rigidbody>();
            rb.isKinematic = true;
            Slime.transform.position = new Vector3(2.2f, 3f, -43f);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}
