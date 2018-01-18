using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script02 : MonoBehaviour
{
	// Variáveis não precisam ser definidas na hora (exceto constantes)
	//
	int    SaudeAvatar = 40;
	string TituloNovo;
	string TituloVelho;

	void Update()
	{
		if( SaudeAvatar > 0 )
		{
			// Cadeia de "if", "else if" e "else"
			//
			if     ( SaudeAvatar < 10 ){ TituloNovo = "Destruído"; }
			else if( SaudeAvatar < 20 ){ TituloNovo = "Machucado"; }
			else if( SaudeAvatar < 30 ){ TituloNovo = "Abalado"; }
			else                       { TituloNovo = "Perfeito"; }

			if( TituloNovo != TituloVelho )
			{
				TituloVelho = TituloNovo;
				Debug.Log( TituloVelho );
			}

			SaudeAvatar --;

			// "gameObject" é o objeto que carrega o script
			// 3 (segundos) é o delay da função
			//
			if( SaudeAvatar == 0 )
			{
				Destroy( gameObject, 3 );
				Debug.Log( "Morto" );
			}
		}
	}
}
