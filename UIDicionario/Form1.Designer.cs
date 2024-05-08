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
            SuspendLayout();
            // 
            // buttonInserir
            // 
            buttonInserir.Location = new Point(95, 98);
            buttonInserir.Name = "buttonInserir";
            buttonInserir.Size = new Size(75, 23);
            buttonInserir.TabIndex = 0;
            buttonInserir.Text = "Inserir";
            buttonInserir.UseVisualStyleBackColor = true;
            // 
            // ButtonRemover
            // 
            ButtonRemover.Location = new Point(95, 149);
            ButtonRemover.Name = "ButtonRemover";
            ButtonRemover.Size = new Size(75, 23);
            ButtonRemover.TabIndex = 0;
            ButtonRemover.Text = "Remover";
            ButtonRemover.UseVisualStyleBackColor = true;
            // 
            // buttonOrder
            // 
            buttonOrder.Location = new Point(525, 149);
            buttonOrder.Name = "buttonOrder";
            buttonOrder.Size = new Size(75, 23);
            buttonOrder.TabIndex = 0;
            buttonOrder.Text = "Ordem";
            buttonOrder.UseVisualStyleBackColor = true;
            // 
            // buttonPreOrder
            // 
            buttonPreOrder.Location = new Point(525, 98);
            buttonPreOrder.Name = "buttonPreOrder";
            buttonPreOrder.Size = new Size(75, 23);
            buttonPreOrder.TabIndex = 0;
            buttonPreOrder.Text = "PreOrdem";
            buttonPreOrder.UseVisualStyleBackColor = true;
            buttonPreOrder.Click += buttonPreOrder_Click;
            // 
            // buttonPostOrder
            // 
            buttonPostOrder.Location = new Point(525, 206);
            buttonPostOrder.Name = "buttonPostOrder";
            buttonPostOrder.Size = new Size(75, 23);
            buttonPostOrder.TabIndex = 0;
            buttonPostOrder.Text = "PosOrdem";
            buttonPostOrder.UseVisualStyleBackColor = true;
            // 
            // listBoxPalavras
            // 
            listBoxPalavras.FormattingEnabled = true;
            listBoxPalavras.ItemHeight = 15;
            listBoxPalavras.Location = new Point(185, 67);
            listBoxPalavras.Name = "listBoxPalavras";
            listBoxPalavras.Size = new Size(258, 199);
            listBoxPalavras.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBoxPalavras);
            Controls.Add(buttonPreOrder);
            Controls.Add(buttonPostOrder);
            Controls.Add(buttonOrder);
            Controls.Add(ButtonRemover);
            Controls.Add(buttonInserir);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button buttonPostOrder;
        private Button buttonInserir;
        private Button ButtonRemover;
        private Button buttonOrder;
        private Button buttonPreOrder;
        private ListBox listBoxPalavras;
    }
}
