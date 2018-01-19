using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script00 : MonoBehaviour
{
	// Esses são alguns tipos de variáveis
	//
	int    MeuValor   = 0;
	float  OutroValor = 12.34f;
	string FraseJoia  = "badabin badabun";
	bool   AchoQueSim = true;
	bool   AchoQueNao = false;

	// Essa é a função de pré-inicialização (específica)
	// Essa função roda mesmo com o script desabilitado
	//
	void Awake()
	{
		MeuValor = 500;
		Debug.Log( MeuValor );
	}

	// Essa é a função de inicialização (específica)
	//
	void Start()
	{
		Debug.Log( MeuValor );
		Debug.Log( MeuValor + OutroValor );
		Debug.Log( MeuValor + FraseJoia );
		Debug.Log( AchoQueSim & AchoQueNao );
	}

	// Essa é a função de repetição (específica)
	//
	void Update()
	{
		MeuValor ++;
		Debug.Log( MeuValor );
	}
}
