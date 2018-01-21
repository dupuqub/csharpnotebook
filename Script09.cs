using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script09 : MonoBehaviour
{
	// Essas variáveis podem ser modificadas no editor do Unity
	//
	public float    velocidade = 5f;
	public string[] controle   = { "a", "d", "w", "s" };

	// O movimento de uma peça será controlado pelo teclado
	//
	void Update()
	{
		// Antes de tudo eu declaro variáveis que serão usadas durante o processo
		//
		var delta    = Time.deltaTime;
		var sentido  = new Dictionary< string, string >();
		var novo_hor = "";
		var novo_ver = "";
		var novo_x   = 0f;
		var novo_y   = 0f;

		// Rodam todos os testes referentes ao teclado
		//
		novo_hor =
			Input.GetKey( controle[ 0 ] ) && !Input.GetKey( controle[ 1 ] )
			? "esquerda"
			: Input.GetKey( controle[ 1 ] ) && !Input.GetKey( controle[ 0 ] )
			? "direita"
			: "nada";

		novo_ver =
			Input.GetKey( controle[ 2 ] ) && !Input.GetKey( controle[ 3 ] )
			? "cima"
			: Input.GetKey( controle[ 3 ] ) && !Input.GetKey( controle[ 2 ] )
			? "baixo"
			: "nada";

		// Dá-se valor ao sentido depois dos testes
		//
		sentido.Add( "horizontal", novo_hor );
		sentido.Add( "vertical", novo_ver );

		// Aplica-se a velocidade atual em variáveis temporárias
		//
		if( sentido[ "horizontal" ] != "nada" )
		{
			novo_x =
				sentido[ "horizontal" ] == "esquerda"
				? -velocidade
				: velocidade;
		}

		if( sentido[ "vertical" ] != "nada" )
		{
			novo_y =
				sentido[ "vertical" ] == "baixo"
				? -velocidade
				: velocidade;
		}

		// E por último move-se o objeto
		//
		transform.Translate( novo_x * delta, novo_y * delta, 0 );
	}
}
