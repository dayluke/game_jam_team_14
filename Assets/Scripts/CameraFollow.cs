using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

	public float smooth_speed = 0.125f;

	public float camera_y_offset;

	public float camera_x_offset;

	void LateUpdate()
	{
		transform.position = new Vector3(target.position.x + camera_x_offset , target.position.y + camera_y_offset, transform.position.z);
	}
}
