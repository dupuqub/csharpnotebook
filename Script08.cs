using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script08 : MonoBehaviour
{
	Vector2 Dadinho = new Vector2( 5, 6 );
	Vector3 Acerola = new Vector3( 5, 6, 7 );
	Vector3 PosicaoTemporaria;

	void Start()
	{
		// Vector2 e 3 são outros tipo de dado
		// Vector2 só pode ter 2 valores (normalmente x e y)
		// Vector3 só pode ter 3 valores (normalmente x, y e z)
		//
		Debug.Log( Dadinho ); // (5.0, 6.0)
		Debug.Log( Acerola ); // (5.0, 6.0, 7.0)

		// Objetos podem ter seu elemento "transform" acessado
		// ("lossyScale" é somente para leitura)
		//
		Debug.Log( "object     = " + transform.gameObject );
		Debug.Log( "type       = " + transform.GetType() );
		Debug.Log( "position   = " + transform.position );
		Debug.Log( "rotation   = " + transform.rotation );
		Debug.Log( "lossyScale = " + transform.lossyScale ); // Relativo ao mundo
		Debug.Log( "localScale = " + transform.localScale ); // Relativo ao superior

		// Como "position" não pode ser diretamente alterado usa-se um "Vector3"
		//
		PosicaoTemporaria = transform.position;

		// O "Vector3" será moldado
		//
		PosicaoTemporaria.x -= 10;
		PosicaoTemporaria.y -= 5;

		// E usado para reconstruir o "position" real
		//
		transform.position = PosicaoTemporaria;
	}

	void Update()
	{
		// "deltaTime" é o tempo entre frames
		//
		var delta = Time.deltaTime;

		// Translate é um tipo de movimento que não precisa de "Vector3"
		// Valores podem ser multiplicados pelo delta para maior suavidade
		//
		transform.Translate( 3 * delta, 0, 0 );
	}
}
