/*
 * Created by SharpDevelop.
 * User: Sidney Lima
 * Date: 1/5/2024
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetoA53572
{
	/// <summary>
	/// Estrutura que agrupa num único identificador as informações de
	/// chave e valor dos dados a guardar numa qualquer estrutura de dados
	/// </summary>
	public struct ParChaveInfo<TKey, TValue> where TKey : IComparable<TKey>
	{
		
		public TKey chave;  // Tipo do campo chave
		public TValue repeticao;  //Informacao que são as repeticoes
		
		/// <summary>
		/// Construtor da struct/classe ParChave
		/// </summary>
		/// <param name="chave">valor do campo  chave</param>
		/// <param name="valor">valor do campo info</param>
		public ParChaveInfo(TKey chave, TValue valor)
		{
			this.chave = chave;
			this.repeticao = valor;
		}
		
		public override string ToString()
		{
			return this.chave  + "( " + this.repeticao + " )";
		}
		
	}
}
