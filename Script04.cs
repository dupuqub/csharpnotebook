using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script04 : MonoBehaviour
{
	// Isso é uma lista PRONTA
	//
	int[] ListaSimples = { 9, 8, 7, 6, 4 };

	// Isso é uma lista CRUA (cheia de zeros)
	//
	int[] OutraLista = new int[ 5 ];

	void Start()
	{
		// Assim se acessa valores de uma lista
		//
		Debug.Log( ListaSimples[ 0 ] + ListaSimples[ 1 ] );

		// Listas podem ser a base de um tipo especial de "for"
		//
		foreach( int Item in ListaSimples ){ Debug.Log( Item ); }

		// Itens de uma lista podem ter seus valores mudados dessa maneira
		//
		OutraLista[ 3 ] = 12;

		Debug.Log( OutraLista[ 3 ] );

		// O tamanho das listas é acessível
		//
		Debug.Log( OutraLista.Length );
	}
}
