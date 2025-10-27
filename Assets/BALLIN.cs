using UnityEngine;

public class BALLIN : MonoBehaviour
{

    public bool thrown = false;
    public float zMagnitude;
    public float xMovement;
    public float yRotation;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        zMagnitude = 500.0f;
        xMovement = 0.125f;
        yRotation = 5.0f;
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

            Transform t = gameObject.transform;

            // Move ball left with A
            if (Input.GetKeyDown(KeyCode.A))
            {
                if (transform.position.x + xMovement <= 0.5)
                {
                    t.Translate(xMovement, 0.0f, 0.0f);
                }
            }
            // Move ball right with D
            if (Input.GetKeyDown(KeyCode.D))
            {
                if (transform.position.x - xMovement >= -0.5)
                {
                    t.Translate(-xMovement, 0.0f, 0.0f);
                }
            }

            // Curve ball left with Q
            if (Input.GetKeyDown(KeyCode.Q))
            {
                t.Rotate(0.0f, -yRotation * Time.deltaTime, 0.0f);
            }
            // Curve ball right with E
            if (Input.GetKeyDown(KeyCode.E))
            {
                t.Rotate(0.0f, yRotation * Time.deltaTime, 0.0f);
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
