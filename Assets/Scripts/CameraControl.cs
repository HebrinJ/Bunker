using UnityEngine;



public class CameraControl : MonoBehaviour
{
	private Camera mainWindowCamera;
    public float minDistance = 5f, maxDistance = 14f;

    private float horizontalCameraMove, verticalCameraMove;
    public float cameraMoveSpeed = 0.03f;
    public int leftBorder = -16, rightBorder = 16, upBorder = 9, downBorder = -9;

    private void Start()
    {
        mainWindowCamera = GetComponent<Camera>();
    }

    private void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") < 0 && (mainWindowCamera.orthographicSize < maxDistance))
        {
            mainWindowCamera.orthographicSize += 0.5f;
        }
        else if(Input.GetAxis("Mouse ScrollWheel") > 0 && (mainWindowCamera.orthographicSize > minDistance))
        {
            mainWindowCamera.orthographicSize -= 0.5f;
        }

        horizontalCameraMove = (Input.GetAxis("Horizontal"));
        verticalCameraMove = (Input.GetAxis("Vertical"));

        if(horizontalCameraMove != 0 || verticalCameraMove != 0)
        {
            transform.Translate(new Vector2(horizontalCameraMove, verticalCameraMove).normalized * cameraMoveSpeed);

        }

        if (transform.position.x > rightBorder)
            transform.position = new Vector3(rightBorder, transform.position.y, transform.position.z);
        if(transform.position.x < leftBorder)
            transform.position = new Vector3(leftBorder, transform.position.y, transform.position.z);
        if (transform.position.y > upBorder)
            transform.position = new Vector3(transform.position.x, upBorder, transform.position.z);
        if(transform.position.y < downBorder)
            transform.position = new Vector3(transform.position.x, downBorder, transform.position.z);
    }
}