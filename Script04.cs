using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script04 : MonoBehaviour
{
	// Isso é um array PRONTO
	//
	int[] ArraySimples = { 9, 8, 7, 6, 4 };

	// Isso é um array CRU (cheio de zeros)
	//
	int[] OutroArray = new int[ 5 ];

	void Start()
	{
		// Assim se acessa valores de um array
		//
		Debug.Log( ArraySimples[ 0 ] + ArraySimples[ 1 ] );

		// Arrays podem ser a base de um tipo especial de "for"
		//
		foreach( int Item in ArraySimples ){ Debug.Log( Item ); }

		// Itens de um Array podem ter seus valores mudados dessa maneira
		//
		OutroArray[ 3 ] = 12;

		Debug.Log( OutroArray[ 3 ] );

		// O tamanho das Arrays é acessado via "Length"
		//
		Debug.Log( OutroArray.Length );
	}
}
