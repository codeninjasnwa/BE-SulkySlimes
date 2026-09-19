using UnityEngine;

public class ResetCanPosition : MonoBehaviour
{
    public GameObject Can;

    public Transform canPos;
    private Vector3 canPos2;
    private Rigidbody rb;
    void Start()
    {
        canPos2 = canPos.position;
        Debug.Log(canPos2);
    }
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("z"))
        {
            transform.position = canPos2;
            Debug.Log(transform.position);
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
    }
}