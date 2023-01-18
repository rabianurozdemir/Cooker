using UnityEngine;

public class PotMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    
    public float speed, xBound;

    #region CashedData

    private Transform _transform;

    #endregion
  
    void Start()
    {
        _transform = transform;
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        if (horizontal > 0)
            _rigidbody.velocity = Vector2.right * speed;
        else if (horizontal < 0)
            _rigidbody.velocity = Vector2.left * speed;
        else
            _rigidbody.velocity = Vector2.zero;

        _transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound ),_transform.position.y);
    }
}
