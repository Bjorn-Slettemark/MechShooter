﻿using System;
using UnityEngine;

public class Item : MonoBehaviour
{
	public event Action<Item, int> Triggered;

	public bool isTarget;

	public void OnMouseDown()
	{
		if (Triggered != null)
		{
			Triggered(this, 12);
		}
	}
}