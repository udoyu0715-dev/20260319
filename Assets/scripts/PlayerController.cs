using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public float speed = 1.0f;

    public Rigidbody2D rig;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var moveAction = InputSystem.actions["Move"];
        var d = moveAction.ReadValue<Vector2>();
        rig.AddForce(d * speed);
    }
}
