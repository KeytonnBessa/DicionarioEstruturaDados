namespace UIDicionario
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
            buttonInserir = new Button();
            ButtonRemover = new Button();
            buttonOrder = new Button();
            buttonPreOrder = new Button();
            buttonPostOrder = new Button();
            listBoxPalavras = new ListBox();
            textBoxKey = new TextBox();
            textBoxValue = new TextBox();
            buttonBuscarBinario = new Button();
            labelValue = new Label();
            labelKey = new Label();
            SuspendLayout();
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(587, 57);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(75, 23);
            buttonInserir.TabIndex = 0;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            buttonInserir.Click += buttonInserir_Click;
            // 
            // ButtonRemover
            // 
            ButtonRemover.Location = new Point(677, 58);
            ButtonRemover.Name = "ButtonRemover";
            ButtonRemover.Size = new Size(75, 23);
            ButtonRemover.TabIndex = 0;
            ButtonRemover.Text = "Remover";
            ButtonRemover.UseVisualStyleBackColor = true;
            ButtonRemover.Click += ButtonRemover_Click;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(515, 214);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(75, 23);
            buttonOrder.TabIndex = 0;
            buttonOrder.Text = "Ordem";
            buttonOrder.UseVisualStyleBackColor = true;
            buttonOrder.Click += buttonOrder_Click;
            // 
            // buttonPreOrder
            // 
            buttonPreOrder.Location = new Point(515, 185);
            buttonPreOrder.Name = "buttonPreOrder";
            buttonPreOrder.Size = new Size(75, 23);
            buttonPreOrder.TabIndex = 0;
            buttonPreOrder.Text = "PreOrdem";
            buttonPreOrder.UseVisualStyleBackColor = true;
            buttonPreOrder.Click += buttonPreOrder_Click;
            // 
            // buttonPostOrder
            // 
            buttonPostOrder.Location = new Point(515, 243);
            buttonPostOrder.Name = "buttonPostOrder";
            buttonPostOrder.Size = new Size(75, 23);
            buttonPostOrder.TabIndex = 0;
            buttonPostOrder.Text = "PosOrdem";
            buttonPostOrder.UseVisualStyleBackColor = true;
            buttonPostOrder.Click += buttonPostOrder_Click;
            // 
            // listBoxPalavras
            // 
            listBoxPalavras.FormattingEnabled = true;
            listBoxPalavras.ItemHeight = 15;
            listBoxPalavras.Location = new Point(236, 185);
            listBoxPalavras.Name = "listBoxPalavras";
            listBoxPalavras.Size = new Size(258, 199);
            listBoxPalavras.TabIndex = 1;
            // 
            // textBoxKey
            // 
            textBoxKey.Location = new Point(236, 58);
            textBoxKey.Name = "textBoxKey";
            textBoxKey.Size = new Size(258, 23);
            textBoxKey.TabIndex = 2;
            // 
            // textBoxValue
            // 
            textBoxValue.Location = new Point(236, 113);
            textBoxValue.Multiline = true;
            textBoxValue.Name = "textBoxValue";
            textBoxValue.Size = new Size(258, 52);
            textBoxValue.TabIndex = 3;
            // 
            // buttonBuscarBinario
            // 
            buttonBuscarBinario.Location = new Point(506, 57);
            buttonBuscarBinario.Name = "buttonBuscarBinario";
            buttonBuscarBinario.Size = new Size(75, 23);
            buttonBuscarBinario.TabIndex = 4;
            buttonBuscarBinario.Text = "Buscar";
            buttonBuscarBinario.UseVisualStyleBackColor = true;
            buttonBuscarBinario.Click += buttonBuscarBinario_Click;
            // 
            // labelValue
            // 
            labelValue.AutoSize = true;
            labelValue.Location = new Point(236, 95);
            labelValue.Name = "labelValue";
            labelValue.Size = new Size(128, 15);
            labelValue.TabIndex = 5;
            labelValue.Text = "Significado (definition)";
            // 
            // labelKey
            // 
            labelKey.AutoSize = true;
            labelKey.Location = new Point(234, 40);
            labelKey.Name = "labelKey";
            labelKey.Size = new Size(247, 15);
            labelKey.TabIndex = 5;
            labelKey.Text = "Palavra que deseja buscar, inserir ou remover:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(labelKey);
            Controls.Add(labelValue);
            Controls.Add(buttonBuscarBinario);
            Controls.Add(textBoxValue);
            Controls.Add(textBoxKey);
            Controls.Add(listBoxPalavras);
            Controls.Add(buttonPreOrder);
            Controls.Add(buttonPostOrder);
            Controls.Add(buttonOrder);
            Controls.Add(ButtonRemover);
            Controls.Add(buttonInserir);
            MaximizeBox = false;
            Name = "Form1";
            ShowIcon = false;
            Text = "Dicionario Arretado - Expressões nordestinas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonPostOrder;
        private Button buttonInserir;
        private Button ButtonRemover;
        private Button buttonOrder;
        private Button buttonPreOrder;
        private ListBox listBoxPalavras;
        private TextBox textBoxKey;
        private TextBox textBoxValue;
        private Button buttonBuscarBinario;
        private Label labelValue;
        private Label labelKey;
    }
}
