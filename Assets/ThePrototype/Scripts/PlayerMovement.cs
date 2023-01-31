using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 firstPos, endPos;
    public float playerSpeed;
    
    private Rigidbody2D _rigidbody;
    
    public float xBound;

    #region CashedData

    private Transform _transform;

    #endregion
    
    void FixedUpdate()
    {
        if (Input.GetMouseButtonDown((0)))
        {
            firstPos = Input.mousePosition;
        }
        else if (Input.GetMouseButton(0))
        {
            endPos = Input.mousePosition;
            float differenceX = endPos.x - firstPos.x;
            transform.Translate(differenceX * Time.deltaTime*playerSpeed/100,0,0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            firstPos = Vector3.zero;
            endPos = Vector3.zero;
        }
        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -xBound, xBound ), transform.position.y);
    }
}
