// Aluno N.: 53572
// Nome....: Sidney de Sousa Lima

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace ProjetoA53572
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		// variáveis globais..
		private TabelaHash<string,int> tabHash;
		
		private int palavrasValaidas; //Armazena o total das palavras validas
		private int totalOcorrencia;  //Armazena o total as Ocorrencias 
		private int ocorreniaUnica;   //Armazena o numero das palavras com ocorrencia unica
		
		private ParChaveInfo<string, int> []vec; //Vector de todos elementos da tabelaHash
		
		/// <summary>
		/// Inicio do programa...
		/// </summary>
		public MainForm()
		{
			
			InitializeComponent();
			tabHash = new TabelaHash<string, int>(500000);
		}
		

		/// <summary>
		/// Evento chamado para escolher ficheiro a analisar
		/// </summary>
		void BtnAbrirFicheiroClick(object sender, EventArgs e)
		{
			OpenFileDialog fdiag = new OpenFileDialog();
			fdiag.Filter="Text files (*.txt)|*.txt|All files (*.*)|*.*";
			DialogResult res = fdiag.ShowDialog();
			if (res!=DialogResult.OK)		// se não escolheu ficheiro
				return;
			this.label2.Text=fdiag.FileName;

			// Ler e analisar o conteúdo do ficheiro;
			Stopwatch crono= new Stopwatch();
			crono.Start();
			//..
		    //..
			LerEAnalisarFicheiro(fdiag.FileName);
			
			//Atribui as variaveis os valores registados 
			palavrasValaidas = tabHash.CountPalavrasValida;
			totalOcorrencia =  tabHash.Cout;
			ocorreniaUnica = tabHash.CountOcorreciaUnica;
			
			vec = 	tabHash.ToArray();
			
			//Ordena o vector(vec) de elementos na tabela por quantidade de ocorrencias
			Ordenacao<string, int>.QuickSort(vec);
			
			crono.Stop();
			
			string strsaida= "Resultado da Analise:\nForam encontradas " +palavrasValaidas +
				" palvras válidas\nTotalizando um total de "+totalOcorrencia+
				" ocorrências.\nForam encontradas " +ocorreniaUnica+
				" palvras com uma só ocorrencia.\nListas de palavras mais comuns:"; // para afixar o resultado da análise...
			
			//Percore o vector ja ordenado ate a posicao 24
			for(int x = 0; x < 25; x++){
				strsaida = strsaida + " "+vec[x].chave.ToLower() + "("+ vec[x].repeticao + ");";
			}
			strsaida = strsaida + "\n\nTempo da execução da tarefa: "+crono.ElapsedMilliseconds+"ms";
			this.lblResult.Text=strsaida;
			
			
		}
		
		/// <summary>
		///  PARTE A do Bloco Principal do problema...
		///  faz a parte de abertura do ficheiro e leitura das diferenetes palavras
		/// </summary>
		/// <param name="filename"></param>
		void LerEAnalisarFicheiro(string filename)
		{
			//ler todos os dados do ficheiro (linha a linha)
			string[] linhas;
			linhas=File.ReadAllLines(filename,System.Text.Encoding.GetEncoding("UTF-8"));
			if (linhas.Length<2) // se linhas 0 ou 1 então este não serve...
				return;
			// para cada linha vamos agora ir buscar as diferentes palavras
			//ai existentes...
			string[] palavras;
			for (int i=0;i<linhas.Length;i++)
			{
				palavras = linhas[i].Split(' ',',','.');
				// e agora, finalmente, para cada palavra
				// vamos fazer o que temos que fazer...
				for (int j=0;j<palavras.Length;j++)
					ProcessarPalavra(palavras[j].Trim());
			}
		}
		
		
		/// <summary>
		/// Metodo que faz analise de uma determinada palavra...
		/// </summary>
		/// <param name="palavra">palavra a ananlizar</param>
		void ProcessarPalavra(string palavra)
		{
			if(this.palavraValida(palavra.ToUpper())){
				tabHash.Add(palavra.ToUpper(), 1);
			}
			
			
		}
		/// <summary>
		/// Metodo axiliar que verifica se a palavra é valida
		/// </summary>
		/// <param name="palavra">palavra para verificar</param>
		/// <returns>retorna true caso for valida</returns>
		private bool palavraValida(string palavra){
			if(palavra.Length >= 4 && palavra.Length <= 11){
				return true;
			}
			else{
				return false;
			}
		}
	}
}
