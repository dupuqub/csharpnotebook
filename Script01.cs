using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script01 : MonoBehaviour
{
	// Funções não podem ser chamadas fora de "Awake", "Start" ou "Update"
	//
	void Start()
	{
		NinjaQuieto();

		Debug.Log( IntBonitao() );
		Debug.Log( FloatManeiro() );
		Debug.Log( StringXou() );
		Debug.Log( BoolHonesto() );

		Debug.Log( Soma( 12, 15 ) );
	}

	// Essa é uma função que não retorna nada
	//
	void NinjaQuieto(){ Debug.Log ( "Jutsu!" ); }

	// Todas as funções abaixo retornam algo
	//
	int    IntBonitao  (){ return 3; }
	float  FloatManeiro(){ return 3.141f; }
	string StringXou   (){ return "vixi"; }
	bool   BoolHonesto (){ return false; }

	// A função abaixo mostra como receber parâmetros
	//
	float Soma( float a, float b ){ return a + b; }
}
