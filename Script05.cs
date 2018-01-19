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
		var MeuNumero    = 5;
		var OutroNumero  = 0.123;
		var MeuNome      = "dunp";
		var MinhaVerdade = false;
		var MinhaLista   = new[]{ "a", "b", "c", "d" };
		var OutraLista   = new[]{ 2, -13, 3.14, 7 };
		var UltimaLista  = new string[ 0 ];
		var MaisUmaLista = new string[ 0 ];

		Debug.Log( MinhaLista );

		// No caso abaixo, qualquer mudança em "MinhaLista" afetará a "UltimaLista"
		//
		UltimaLista = MinhaLista;

		MinhaLista[ 0 ] = "abacate";

		Debug.Log( UltimaLista[ 0 ] ); // "abacate"

		// "UltimaLista" é apenas um link para "MinhaLista" nesse momento
		//
		UltimaLista[ 0 ] = "berimbau";

		Debug.Log( MinhaLista[ 0 ] ); // "berimbau"

		// A solução aqui é copiar a lista
		//
		MaisUmaLista = new string[ MinhaLista.Length ]; // redimensionar antes
		MinhaLista.CopyTo( MaisUmaLista, 0 ); // à partir do index 0

		MaisUmaLista[ 0 ] = "iguana";

		Debug.Log( MinhaLista[ 0 ] ); // "berimbau"
		Debug.Log( MaisUmaLista[ 0 ] ); // "iguana"
	}
}
