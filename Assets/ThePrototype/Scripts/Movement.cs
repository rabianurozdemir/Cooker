using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D _rb;
    private float _moveSpeed;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        _moveSpeed = 10f;
    }

    void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    
                    if (touch.position.x < Screen.width/2)
                    {
                        _rb.velocity = new Vector2(-_moveSpeed, 0f);
                    }

                    if (touch.position.x > Screen.width/2)
                    {
                        _rb.velocity = new Vector2(_moveSpeed, 0f);
                    }

                    break;
                
                case TouchPhase.Ended:
                    
                    _rb.velocity = new Vector2(0f, 0f);
                    break;
            }
        }
    }
}
