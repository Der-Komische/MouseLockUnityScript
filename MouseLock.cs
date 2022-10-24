using UnityEngine;
using System.Collections;

public class MouseLock : MonoBehaviour
{
	public KeyCode escapeKey = KeyCode.Escape;

	void Update()
	{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
	}
}
