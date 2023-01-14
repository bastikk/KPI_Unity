using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public GameObject player;
    public CharacterController characterController;
    private Vector3 moveDirection = Vector3.zero;


    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        moveDirection.x = horizontal;
        moveDirection.y -= 10f * Time.deltaTime;
        moveDirection.z = vertical;

        if (moveDirection.magnitude >= 0.1f)
        {
            characterController.Move(moveDirection * 10f * Time.deltaTime);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            moveDirection.y = 3f;
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            DontDestroyOnLoad(player);
            SceneManager.LoadScene("SampleScene2");
        }

    }
}
