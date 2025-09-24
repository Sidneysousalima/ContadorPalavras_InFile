// Aluno N.: xxxxx
// Nome....: colocar o nome do aluno..


namespace ProjetoA53572
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnAbrirFicheiro = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.lblResult = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnAbrirFicheiro
			// 
			this.btnAbrirFicheiro.Location = new System.Drawing.Point(12, 53);
			this.btnAbrirFicheiro.Name = "btnAbrirFicheiro";
			this.btnAbrirFicheiro.Size = new System.Drawing.Size(101, 23);
			this.btnAbrirFicheiro.TabIndex = 0;
			this.btnAbrirFicheiro.Text = "Abrir Ficheiro";
			this.btnAbrirFicheiro.UseVisualStyleBackColor = true;
			this.btnAbrirFicheiro.Click += new System.EventHandler(this.BtnAbrirFicheiroClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(557, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Contador de ocorrências de palavras em Ficheiros de Texto";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(119, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(466, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Ficheiro em Analise: ";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblResult
			// 
			this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblResult.Location = new System.Drawing.Point(13, 99);
			this.lblResult.Name = "lblResult";
			this.lblResult.Size = new System.Drawing.Size(563, 257);
			this.lblResult.TabIndex = 3;
			this.lblResult.Text = "Resultados da Análise:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(588, 393);
			this.Controls.Add(this.lblResult);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnAbrirFicheiro);
			this.Name = "MainForm";
			this.Text = "ProjetoAxxxxx";
			this.ResumeLayout(false);

		}
		private System.Windows.Forms.Label lblResult;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnAbrirFicheiro;
	}
}
