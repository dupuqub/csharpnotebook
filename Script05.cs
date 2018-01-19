using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script05 : MonoBehaviour
{
	// O interior de uma "class" é considerado contexto global

	void Start()
	{
		// "var" pode só existir em contextos locais (dentro de funções)
		//
		var MeuNumero   = 5;
		var OutroNumero = 0.123;
		var MeuNome     = "dunp";
		var MinhaOpcao  = false;
		var MeuArray    = new[]{ "a", "b", "c", "d" };
		var OutroArray  = new string[ 0 ];
		var MaisUmArray = new string[ 0 ];

		Debug.Log( MeuArray );

		// No caso abaixo, qualquer mudança em "MeuArray" afetará a "OutroArray"
		//
		OutroArray = MeuArray;

		MeuArray[ 0 ] = "abacate";

		Debug.Log( OutroArray[ 0 ] ); // "abacate"

		// "OutroArray" é apenas um link para "MeuArray" nesse momento
		//
		OutroArray[ 0 ] = "iguana";

		Debug.Log( MeuArray[ 0 ] ); // "iguana"

		// A solução aqui é copiar o array
		//
		MaisUmArray = new string[ MeuArray.Length ]; // redimensionar antes
		MeuArray.CopyTo( MaisUmArray, 0 ); // à partir do index 0

		MaisUmArray[ 0 ] = "iguana";

		Debug.Log( MeuArray[ 0 ] ); // "berimbau"
	}
}
