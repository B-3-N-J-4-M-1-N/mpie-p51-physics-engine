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
            // Increase zMagnitude with W
            if (Input.GetKeyDown(KeyCode.W)) 
            {
                zMagnitude += 500.0f;
                if (zMagnitude > 5000.0f) 
                {
                    zMagnitude = 5000.0f;
                }
            }
            // Decrease zMagnitude with S
            if (Input.GetKeyDown(KeyCode.S)) 
            {
                zMagnitude -= 500.0f;
                if (zMagnitude < 500.0f) 
                {
                    zMagnitude = 500.0f;
                }
            }

            // Move ball left with A
            if (Input.GetKeyDown(KeyCode.A))
            {
                //...
            }
            // Move ball right with D
            if (Input.GetKeyDown(KeyCode.D))
            {
                //...
            }

            // Curve ball left with Q
            if (Input.GetKeyDown(KeyCode.Q))
            {
                //...
            }
            // Curve ball right with E
            if (Input.GetKeyDown(KeyCode.E))
            {
                //...
            }

            // Throw ball with spacebar
            if (Input.GetKeyDown(KeyCode.Space))
            {
                thrown = true;
                Rigidbody rb = GetComponent<Rigidbody> ();
                rb.AddForce(new Vector3(0.0f, 0.0f, -zMagnitude));
            }
        }
    }
}
