using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq; // É necessário declarar o uso da biblioteca LINQ

public class Script07 : MonoBehaviour
{
	void Start()
	{
		string[] Fios       = { "quiabo", "uva", "barata", "luz", "pote" };
		string[] OutrosFios = { "oculi", "mini", "bambu", "limpo" };

		// Aqui a LINQ cria um novo array como o "filter" do JavaScript
		//
		var Mensagem   = "";
		var FiosCurtos = from Item in Fios where Item.Length < 5 select Item;

		foreach( var Item in FiosCurtos ) Mensagem += Item + " ";

		Debug.Log( Mensagem );

		// Essa é função da LINQ une duas listas
		//
		var VariosFios = Fios.Concat( OutrosFios );

		Debug.Log( VariosFios.Count() ); // 9 = 5 (Fios) + 4 (OutrosFios)

		// LINQ retorna "Enumerables" por isso "Count()" e não "Length"
		//
		Debug.Log( FiosCurtos.GetType() );
		Debug.Log( VariosFios.GetType() );

		// LINQ server para mais uma porção de funções, por exemplo abaixo
		//
		int[] Numeros       = { 9, 14, 2, 7 };
		int[] OutrosNumeros = { 3, 2, 5, 14 };

		Debug.Log( Numeros.Sum() ); // 32 = 9 + 14 + 2 + 7
		Debug.Log( Numeros.Min() ); // 2
		Debug.Log( Numeros.Max() ); // 14

		Debug.Log( Numeros.Contains( 1 ) ); // False
		Debug.Log( Numeros.Contains( 2 ) ); // True

		// Inclusive achar itens em comum ou distintos entre grupos, etc
		//
		var Comuns =
			from   Item
			in     OutrosNumeros
			where  Numeros.Contains( Item )
			select Item;

		// A exclamação (!) simboliza o inverso de uma operação
		//
		var Distintos =
			from   Item
			in     OutrosNumeros
			where  !Numeros.Contains( Item )
			select Item;

		Debug.Log( Comuns.Sum() ); // 16 = 14 + 2
		Debug.Log( Distintos.Sum() ); // 8 = 3 + 5

		// "Distintos" não é uma lista, portanto acesso aos seus itens é diferente
		//
		Debug.Log( Distintos.ElementAt( 0 ) ); // 3
	}
}
