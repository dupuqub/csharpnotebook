﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
	public float Forca = 200f;

	// Não podem ser definidos fora de funções
	//
	Rigidbody2D Corpo;
	SpriteRenderer Renderizador;
	Vector3 Direcao;

	// "Rigidbody2D" é um componente que deve ser adicionado pela UI do Unity
	// "SpriteRenderer" é nativo em um "Sprite"
	//
	void Start()
	{
		Corpo = GetComponent<Rigidbody2D>();
		Renderizador = GetComponent<SpriteRenderer>();
	}

	void Update()
	{
		// "left" = seta da esquerda
		//
		if( Input.GetKey( "left" ) )
		{
			// "AddForce" é o método adequado quando mexendo com física
			// Mexer diretamente em "transform.position" pode gerar "clipping"
			//
			Corpo.AddForce( new Vector2( -Forca, 0 ) );
			Direcao = new Vector3( -1f, 0, 0 );
			Renderizador.flipX = true;
		}

		// "right" = seta da direita
		//
		else if( Input.GetKey( "right" ) )
		{
			Corpo.AddForce( new Vector2( Forca, 0 ) );
			Direcao = new Vector3( 1f, 0, 0 );
			Renderizador.flipX = false;
		}

		Vector3 Inicio = transform.position;
		Color CorRaio = new Vector4( 1f, 0, 0, 1 );
		float Duracao = 0.01f;
		bool Profundo = false; // raio pode ou não ficar atrás de outros objetos

		Debug.DrawRay( Inicio, Direcao, CorRaio, Duracao, Profundo );
	}
}
