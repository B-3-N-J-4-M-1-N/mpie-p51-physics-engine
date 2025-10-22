using UnityEngine;

public class BALLIN : MonoBehaviour
{

    public float zMagnitude;
    public bool thrown = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zMagnitude = 500.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!thrown)
        {
            if (Input.GetKeyDown(KeyCode.W)) 
            {
                zMagnitude += 500.0f;
                if (zMagnitude > 5000.0f) 
                {
                    zMagnitude = 5000.0f;
                }
            }
            else if (Input.GetKeyDown(KeyCode.S)) 
            {
                zMagnitude -= 500.0f;
                if (zMagnitude < 500.0f) 
                {
                    zMagnitude = 500.0f;
                }
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                thrown = true;
                Rigidbody rb = GetComponent<Rigidbody> ();
                rb.AddForce(new Vector3(0.0f, 0.0f, -zMagnitude));
            }
        }
    }
}
