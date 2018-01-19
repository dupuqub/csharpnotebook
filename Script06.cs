using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script06 : MonoBehaviour
{
	// Variáveis globais podem ser públicas (editáveis pela UI da unity)
	//
	public int    Saude      = 0;
	public string Nome       = "Hermonidus";
	public int[]  MuitaCoisa = { 0, 1, 2, 3, 4 };

	// Abaixo são exemplos de listas
	//
	void Start()
	{
		// Além de arrays existem listas
		//
		var MinhaLista = new List<float>();

		MinhaLista.Add( 3.21f );
		MinhaLista.Add( 12 );
		MinhaLista.Add( 0.7f );

		var MensagemLista = "";

		// "foreach" não expõe o index dos elementos da lista
		//
		foreach( var Item in MinhaLista ) MensagemLista += Item + " ";

		Debug.Log( MensagemLista );
		Debug.Log( MinhaLista.Count ); // Como o "Length" dos arrays

		// Usa-se um "for" comum para expor o index dos elementos da lista
		//
		for( var Index = 0; Index < MinhaLista.Count; Index ++ )
		{
			Debug.Log( Index + " : " + MinhaLista[ Index ] );
		}
	}
}
