﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class RayCast : MonoBehaviour {

	private Camera _camera;

	public int GuiAimSize = 12;
	public int _rayDistance = 200;
	public string CurrentTag = string.Empty;

	// Use this for initialization
	void Start () {
		_camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		bool transform = Input.GetButtonDown("Transform");
		bool capture = Input.GetButtonDown("Capture");

		if(transform ^ capture)
		{
			Vector3 point = new Vector3(_camera.pixelWidth / 2, _camera.pixelHeight / 2, 0);
			Ray ray = _camera.ScreenPointToRay(point);
			RaycastHit hit;
			if(Physics.Raycast(ray, out hit))
			{
				FPSAI fsapi = hit.transform.root.GetComponent<FPSAI>();
				if(fsapi == null)
					return;

				GameObject gameObject = fsapi.gameObject;

				if(string.IsNullOrEmpty(gameObject.tag) || !gameObject.tag.EndsWith("Enemy", System.StringComparison.InvariantCultureIgnoreCase))
					return;

				if(transform && !string.IsNullOrEmpty(CurrentTag) && CurrentTag != gameObject.tag)
				{
					gameObject.tag = CurrentTag;
					CurrentTag = string.Empty;
				}
				else if(capture && !string.IsNullOrEmpty(gameObject.tag))
				{
					CurrentTag = gameObject.tag;
				}
			}
		}
	}

	void OnGUI()
	{
		float posX = _camera.pixelWidth / 2 - GuiAimSize / 4;
		float posY = _camera.pixelHeight / 2 - GuiAimSize / 4;
		GUI.Label(new Rect(posX, posY, GuiAimSize, GuiAimSize), "*");
	}
}
