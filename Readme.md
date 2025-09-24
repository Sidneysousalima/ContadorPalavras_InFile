# Contador de ocorrências de Palavras em Ficheiros de Texto.

Este projeto faz uma analise estatica de ficheros de texto, utilizando uma Tabela de Hahs, com estruturas de dados Estáticos - Vector e utilizei o metodo QuickSort para ordenação do vector de palavras

### A análise do ficheiro consistirá na apresentação da seguinte informação:

Número de palavras válidas encontradas no texto (ver no fim o que são as
palavras válidas);

- Total de ocorrências de palavras válidas.
- Listagem das 25 palavras válidas mais utilizadas no texto (e respetivo número
  de ocorrências)
- Número de palavras válidas que tenham ocorrido no texto apenas uma vez.
- Tempo de execução da análise do ficheiro.

### Caracterização dos Ficheiros para análise:

- Os ficheiros a analisar estão no formato de texto, codificação UTF-8.
- O limite máximo de palavras existentes no texto é de 500.000 palavras.
- É no entanto garantido que não existirão mais do que 50.000 palavras distintas e válidas dentro de cada um dos ficheiros de teste e que cada palavra, no ficheiro de texto, tem dimensão máxima de 20 caracteres.

### Palavras válidas:

De forma a simplificar a análise do ficheiro, só deverão ser consideradas como
válidas:

- As palavras constituídas por letras de a a z (acentuadas ou não, maiúsculas e minúsculas) e de dimensão entre 4 e 11 caracteres inclusive (todas as restantes deverão ser ignoradas).
- Considere como palavra o conjunto de caracteres que está separado dos restantes por um dos seguintes caracteres: ‘ ‘ (espaço), ‘,’ (vírgula) e ‘.’ (ponto)
- Não deverá ser feita diferenciação entre maiúsculas e minúsculas, ou seja a palavra “PedRo” deverá ser considerada igual à palavra “pedro”.

### 🗂️ Estrutura do Projeto

MainForm.cs: interface gráfica e lógica principal <br>

TabelaHash.cs: implementação de tabela de hash para armazenamento e contagem das palavras <br>

ParChaveInfo.cs: estrutura auxiliar para pares (palavra, ocorrências) <br>

Ordenacao.cs: algoritmo de ordenação (QuickSort) usado para organizar as palavras por número de ocorrências<br>

### ⚙️ Tecnologias Utilizadas

Linguagem: C#

Plataforma: .NET (Console Application)

Estruturas de Dados: Tabela de Hahs

Algoritmo de ordenação: QuickSort

### 📌 Melhorias Futuras

- Suporte para múltiplos idiomas e conjuntos de caracteres

I- gnorar “stopwords” (ex.: artigos e preposições)

- Exportar resultados para CSV ou HTML
