/*
 * Created by SharpDevelop.
 * User: Sidney Lima
 * Date: 1/5/2024
 * Time: 10:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

namespace ProjetoA53572
{
	/// <summary>
	/// Implementa uma Tabela de Hahs, usando estruturas de dados Estáticos - Vector
	/// </summary>
	public class TabelaHash<Key, T> where Key : IComparable<Key>
	{
		private ParChaveInfo<Key,T>[] vec; // vector contendo chaves a repeticao..
		private bool[] vocupados;		   // vector indicativo de ocupação da posição na tabela
		private int totalPalavras;  	   // Totaliza um total de ocoorencia
		private int palavrasValidas;       // Total de Palavras validas
		private int totalOcorrenciaUnicas; // Total de Palavras com ocorrencia unica
		
		#region Construtor
		/// <summary>
		/// Construtor da TabelaHash
		/// </summary>
		/// <param name="tamanho">Máximo de elementos da tabela</param>
		public TabelaHash(int tamanho)
		{
			this.vec = new ParChaveInfo<Key, T>[tamanho];
			this.vocupados = new bool[tamanho];
			this.totalPalavras = 0;
			this.palavrasValidas = 0;
			this.totalOcorrenciaUnicas = 0;
		}
		#endregion
		
		#region Propriedades
		
		/// <summary>
		/// Devolve o numero de ocorrencia das Palvras validas na tabela
		/// Complexidade O(1)
		/// </summary>
		public int Cout
		{
			get{
				return this.totalPalavras;
			}
		}
		
		/// <summary>
		/// Devolve o total de palavras validas
		/// Complexidade O(1)
		/// </summary>
		public int CountPalavrasValida
		{
			get{
				return this.palavrasValidas;
			}
		}
		
		/// <summary>
		/// Devolve o total de palavras com ocorrencias unicas
		/// Complexidade O(1)
		/// </summary>
		public int CountOcorreciaUnica
		{
			get
			{
				return this.totalOcorrenciaUnicas;
			}
		}
		#endregion
		
		#region Métodos dos objectos
		
		/// <summary>
		/// Método que recebe uma chave e calcula o indice onde o colocar
		/// faz uso do método HashCode existente em todos os objectos csharp
		/// </summary>
		/// <param name="chave">chave a calcular o hashcode</param>
		/// <returns>o indice da tabela conde deverá ser colocado o elemento</returns>
		private int FuncaoHash(Key chave)
		{
			//Calcular e devolver o resto da divisao do valor da chave pela
			//capacidade maxima da tabela;
			return Math.Abs(chave.GetHashCode()) % this.vec.Length;
		}
		
		
		/// <summary>
		/// Método que faz o ReHashing em caso de colisão
		/// Esta versão implementa o ExameQuadrático (+1,+4,+8,+16,...)
		/// </summary>
		/// <param name="pos">posição antiga do indice</param>
		/// <param name="vez">tentativa numero..</param>
		/// <returns>nova posição do ínice</returns>
		private int ReHash(int pos,int vez)
		{
			return (pos + vez*vez) % this.vec.Length;
		}
		
		/// <summary>
		/// Inserir uma palavra na tabela de Hash
		/// </summary>
		/// <param name="chave">A palavra</param>
		/// <param name="valor">repeticao</param>
		/// <returns></returns>
		public bool Add(Key chave, T valor)
		{
			int indece, pos;
			indece = this.FuncaoHash(chave); //Pegar o indece onde inserrir a palavra
			
			//caso exista palvra nesta posicao
			if(this.vocupados[indece] == true){
				//Caso as palvras forem iguais
				if(this.vec[indece].chave.CompareTo(chave) == 0){
					
					//Incrementa as repetiçoes caso a palavra ja existe
					//Converte um dos valor em tipo dynamic, permitindo que o tipo seja determinado em tempo de execução
					this.vec[indece].repeticao = (T)((dynamic)this.vec[indece].repeticao + valor);
					
					this.totalPalavras++; // Incrementa o total de palavras
					
					//si caso for a segunda repetição atualiza a ocorrencia unica tirando -1
					if(vec[indece].repeticao.Equals(2)){
						this.totalOcorrenciaUnicas--;
					}
					
					return true;
				}
				
				//ir a procura da possicao vazia
				pos=indece;		// memorizar uma volta
				int vez = 1;
				while(this.vocupados[pos] == true && this.vec[pos].chave.CompareTo(chave) != 0){
					pos = this.ReHash(pos, vez++);
					
					if(pos == indece){
						return false;
					}
				} //Fim do While
				
				//Si encontrou a posicao vazia adiciona
				if(this.vocupados[pos] == false){
					
					this.vocupados[pos] = true;
					this.vec[pos].chave = chave;
					this.vec[pos].repeticao = valor;
					
					this.totalPalavras++;//aumenta o total das palavras
					this.palavrasValidas++; // aumenta p total das palavras validas
					this.totalOcorrenciaUnicas++; //adiciona +1 as ocorrencias unicas
					return true;
				}
				//Si caso a posisao ja tiver uma palavra igual
				if(this.vec[pos].chave.CompareTo(chave) == 0){
					
					//Incrementa as repetiçoes caso a palavra ja existe
					//Converte um dos valor em tipo dynamic, permitindo que o tipo seja determinado em tempo de execução
					this.vec[pos].repeticao = (T)((dynamic)this.vec[pos].repeticao + valor);
					
					this.totalPalavras++; //Aumenta o total de palavras
					
					//si caso for a segunda repetição atualiza a ocorrencia unica 
					if(this.vec[pos].repeticao.Equals(2)){
						this.totalOcorrenciaUnicas--;
					}
					return true;
				}
				
			} //Fim do if
			
			//Quando a posisao estiver vazia
			this.vocupados[indece] = true;
			this.vec[indece].chave = chave;
			this.vec[indece].repeticao = valor;
			this.totalPalavras++;
			this.palavrasValidas++;
			this.totalOcorrenciaUnicas++;
			
			return true;
		}
		
		
		/// <summary>
		/// Metodo que devolve os elementos tabela Hash na forma de vector
		/// Complexidade O(N)
		/// </summary>
		/// <returns></returns>
		public ParChaveInfo<Key,T>[] ToArray()
		{
			if(this.Cout == 0)
				return null;
			
			//Crea novo objeto com o tamanho sendo o total de palavras validadas
			//garantido assim que o vector tenha o tamanho ideal para armazenar as palavras 
			ParChaveInfo<Key,T>[] vector = new ParChaveInfo<Key, T>[this.CountPalavrasValida]; 
			
			for(int i = 0, j = 0; i < this.vec.Length; i++){
				if(this.vocupados[i] == true)
				{
					vector[j++] = new ParChaveInfo<Key, T>(this.vec[i].chave, this.vec[i].repeticao);
				}
			}
			return vector;
		}
		
		#endregion
		
	}
}
