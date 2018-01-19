using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script03 : MonoBehaviour
{
	void Start()
	{
		int MeuNumero = 0;

		// Isso é um "for"
		//
		for( int Index = 3; Index > 0; Index -- )
		{
			Debug.Log( Index );
		}

		// Isso é um "while" FINITO
		//
		while( MeuNumero < 10 )
		{
			MeuNumero ++;

			if( MeuNumero == 10 ){ Debug.Log( "finito completo" ); }
		}

		// Isso é um "while" INFINITO (precisa de "break")
		//
		while( true )
		{
			MeuNumero ++;

			if( MeuNumero == 20 )
			{
				Debug.Log( "infinito completo" );
				break;
			}
		}

		// "this" é o próprio script
		//
		Debug.Log( this );

		// Esse script se destrói do objeto depois de rodar
		//
		Destroy( this, 0 );
	}
}
