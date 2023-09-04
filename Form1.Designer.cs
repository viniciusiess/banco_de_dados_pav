namespace ListaContatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button2 = new Button();
            button3 = new Button();
            buIncluir_Click = new Button();
            buSelecionar_Click = new Button();
            buAlterar_Click = new Button();
            buExcluir_Click = new Button();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(79, 34);
            button2.Name = "button2";
            button2.Size = new Size(260, 23);
            button2.TabIndex = 1;
            button2.Text = "Conectar";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(79, 63);
            button3.Name = "button3";
            button3.Size = new Size(260, 23);
            button3.TabIndex = 2;
            button3.Text = "Desconectar";
            button3.UseVisualStyleBackColor = true;
            // 
            // buIncluir_Click
            // 
            buIncluir_Click.Location = new Point(79, 92);
            buIncluir_Click.Name = "buIncluir_Click";
            buIncluir_Click.Size = new Size(260, 23);
            buIncluir_Click.TabIndex = 3;
            buIncluir_Click.Text = "Incluir";
            buIncluir_Click.UseVisualStyleBackColor = true;
            buIncluir_Click.Click += buIncluir_Click_Click;
            // 
            // buSelecionar_Click
            // 
            buSelecionar_Click.Location = new Point(79, 121);
            buSelecionar_Click.Name = "buSelecionar_Click";
            buSelecionar_Click.Size = new Size(260, 23);
            buSelecionar_Click.TabIndex = 4;
            buSelecionar_Click.Text = "Selecionar";
            buSelecionar_Click.UseVisualStyleBackColor = true;
            buSelecionar_Click.Click += buSelecionar_Click_Click;
            // 
            // buAlterar_Click
            // 
            buAlterar_Click.Location = new Point(79, 150);
            buAlterar_Click.Name = "buAlterar_Click";
            buAlterar_Click.Size = new Size(260, 23);
            buAlterar_Click.TabIndex = 5;
            buAlterar_Click.Text = "Alterar";
            buAlterar_Click.UseVisualStyleBackColor = true;
            buAlterar_Click.Click += buAlterar_Click_Click;
            // 
            // buExcluir_Click
            // 
            buExcluir_Click.Location = new Point(79, 179);
            buExcluir_Click.Name = "buExcluir_Click";
            buExcluir_Click.Size = new Size(260, 23);
            buExcluir_Click.TabIndex = 6;
            buExcluir_Click.Text = "Excluir";
            buExcluir_Click.UseVisualStyleBackColor = true;
            buExcluir_Click.Click += buExcluir_Click_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(422, 248);
            Controls.Add(buExcluir_Click);
            Controls.Add(buAlterar_Click);
            Controls.Add(buSelecionar_Click);
            Controls.Add(buIncluir_Click);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button buIncluir_Click;
        private Button buSelecionar_Click;
        private Button buAlterar_Click;
        private Button buExcluir_Click;
    }
}