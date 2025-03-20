using UnityEngine;

public class Rotate : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private Vector3 angularV, torqe;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetMouseButtonDown(1))
        {
            rb.AddTorque(torqe);
        }
        else if (Input.GetKeyDown(KeyCode.Z))
        {
            rb.angularVelocity = Vector3.zero;
        }
    }
}
    
