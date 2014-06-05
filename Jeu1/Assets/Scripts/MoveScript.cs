﻿using UnityEngine;

/// <summary>
/// Déplace l'objet
/// </summary>
public class MoveScript : MonoBehaviour
{
	// 1 - Designer variables
	
	/// <summary>
	/// Vitesse de déplacement
	/// </summary>
	public Vector2 speed = new Vector2(10, 10);
	
	/// <summary>
	/// Direction
	/// </summary>
	public Vector2 direction = new Vector2(-1, 0);
	
	private Vector2 movement;
	
	void Update()
	{
		// 2 - Calcul du mouvement
		movement = new Vector2(
			speed.x * direction.x,
			speed.y * direction.y);
	}
	
	void FixedUpdate()
	{
		// Application du mouvement
		rigidbody2D.velocity = movement;
	}
}