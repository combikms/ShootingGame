using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    void Update()
    {
        // <방법 1>
        // float horizontalInput = Input.GetAxisRaw("Horizontal");
        // Vector3 moveTo = new Vector3(horizontalInput, 0f, 0f);
        // transform.position += moveTo * moveSpeed * Time.deltaTime;

        // <방법 2>
        Vector3 moveTo = new Vector3(moveSpeed * Time.deltaTime, 0, 0);
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position -= moveTo;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += moveTo;
        }
    }
}
