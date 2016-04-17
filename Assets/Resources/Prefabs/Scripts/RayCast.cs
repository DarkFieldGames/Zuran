using System;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Camera))]
public class RayCast : MonoBehaviour
{

	private Camera _camera;
	private Image _cursorFillImage;

	public int GuiAimSize = 12;
	public int _rayDistance = 200;

	private string _currentTag = String.Empty;

	public String CurrentTag
	{
		get
		{
			return _currentTag;
		}
		set
		{
			_currentTag = value;
			SetCursor(_currentTag);
		}
	}

	// Use this for initialization
	void Start()
	{
		_camera = GetComponent<Camera>();
		_cursorFillImage = GameObject.FindGameObjectWithTag("Fill").GetComponent<Image>();
		_cursorFillImage.color = Color.clear;
	}

	// Update is called once per frame
	void Update()
	{
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

	private void SetCursor(string currentTag)
	{
		if(String.IsNullOrEmpty(currentTag))
		{
			_cursorFillImage.color = Color.clear;
		}
		else
		{
			var color = FindFullColorFromTag(currentTag);
			color.a = 30;
			_cursorFillImage.color = color;
		}
	}

	private Color FindFullColorFromTag(String tag)
	{
		switch(tag)
		{
			case "YellowEnemy":
				return Color.yellow;
			case "RedEnemy":
				return Color.red;
			case "BlueEnemy":
				return Color.blue;
			case "GreenEnemy":
				return Color.green;
			default:
				return Color.gray;
		}
	}
}
