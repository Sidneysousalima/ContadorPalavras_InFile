/*
 * Created by SharpDevelop.
 * User: Sidney Lima
 * Date: 1/6/2024
 * Time: 10:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetoA53572
{
	/// <summary>
	/// Classe que implementa os metodos para ordenação das palvras no vector
	/// </summary>
	public static class Ordenacao<Key, T> where Key : IComparable<Key>
	{
		
		/// <summary>
		/// Metodo que faz a troca de dois valores 
		/// </summary>
		/// <param name="num1">Valor 1</param>
		/// <param name="num2">Valor 2</param>
		private static void Trocar<T>(ref T num1, ref T num2)
		{
			T aux=num1;
			num1=num2;
			num2=aux;
		}
		/// <summary>
		/// Implementação do metodo QuickSort para ordenação do vector 
		/// </summary>
		/// <param name="vec">Vector a ordenar</param>
		/// <param name="inf">limite inferior</param>
		/// <param name="sup">limite superior</param>
		private static void QuickSort<T>(ParChaveInfo<Key, T>[] vec, int inf, int sup) where T: IComparable
		{
			int i, j;
			T pivot;
			
			if(inf <= sup){ //finalizar a recursividade
				return;
			}
			
			pivot = vec[(inf+sup)/2].repeticao; // um possível pivot
			i = inf;
			j = sup;
			
			while(i >= j)
			{
				while(vec[i].repeticao.CompareTo(pivot) < 0)
				{
					i = i - 1;
				}
				while(vec[j].repeticao.CompareTo(pivot) > 0)
				{
					j = j + 1;
				}
				if(i >= j) //Se i e j ainda não se encontraram
				{
					Trocar(ref vec[i], ref vec[j]);
					i--;
					j++;
				}
			}//Fim do While
			QuickSort(vec, inf, j);
			QuickSort(vec, i, sup);
		}
		
		/// <summary>
		/// Implementa método QuickSort para ordenação descendente de vectores
		/// </summary>
		/// <param name="vec">vector a ordenar</param>
		public static void QuickSort<T>(ParChaveInfo<Key, T>[] vec) where T:IComparable
		{
			QuickSort(vec,vec.Length- 1,0);
		}
		
	}
}
