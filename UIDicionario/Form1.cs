using System.Reflection.PortableExecutable;
using iText.Kernel.Pdf;
using iText.Kernel.Pdf.Canvas.Parser;
using iText.Kernel.Pdf.Canvas.Parser.Listener;
using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using DicionarioEstrutura;  // Certifique-se de incluir isso para List<string>

namespace UIDicionario
{
    public partial class Form1 : Form
    {
        BinaryTree tree = new BinaryTree();
        string pdfPath = "/dicionario-arretado.pdf";
        public Form1()
        {
            InitializeComponent();

            /*BinaryTree tree = new BinaryTree();

            string pdfPath = "C:/dicionario-arretado.pdf";
            ExtractWordsAndInsertIntoTree(pdfPath, tree);

            tree.PrintInOrder();*/

        }

        private void Form1_Load(object sender, EventArgs e)
        {


            //string pdfPath = "C:/dicionario-arretado.pdf";
            ExtractWordsAndInsertIntoTree(pdfPath, tree);

            // tree.PrintInOrder();
        }

        public static List<string> ExtractTextFromPDF(string pdfPath)
        {
            List<string> pagesText = new List<string>();

            using (PdfReader reader = new PdfReader(pdfPath))
            {
                using (PdfDocument pdfDoc = new PdfDocument(reader))
                {
                    for (int page = 1; page <= pdfDoc.GetNumberOfPages(); page++)
                    {
                        PdfPage pdfPage = pdfDoc.GetPage(page);
                        ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                        string currentPageText = PdfTextExtractor.GetTextFromPage(pdfPage, strategy);
                        pagesText.Add(currentPageText);
                    }
                }
            }

            return pagesText;
        }

        // Método ajustado para usar a lista de páginas
        public void ExtractWordsAndInsertIntoTree(string filePath, BinaryTree tree)
        {
            List<string> pagesText = ExtractTextFromPDF(filePath);

            foreach (string pageText in pagesText)
            {
                string[] lines = pageText.Split('\n');
                foreach (string line in lines)
                {
                    int delimiterCount = line.Count(c => c == '–');
                    if (delimiterCount == 1)
                    {
                        string[] parts = line.Split(new string[] { " – " }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 2)
                        {
                            string word = parts[0].Trim();
                            string definition = parts[1].Trim();
                            tree.Insert(word, definition);
                            AdicionarLista(word, definition);
                        }
                    }
                }
            }
        }

        private void buttonPreOrder_Click(object sender, EventArgs e)
        {
            listBoxPalavras.Items.Clear();
            List<string> items = tree.GetPreOrder();
            foreach (var item in items)
            {
                listBoxPalavras.Items.Add(item);
            }
        }
        public void AdicionarLista(string word, string definition)
        {
            //listBoxPalavras listagem;
            listBoxPalavras.Items.Add(word + " – " + definition);
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            string word = textBoxKey.Text.Trim();
            string definition = textBoxValue.Text.Trim();

            if (!string.IsNullOrEmpty(word) && !string.IsNullOrEmpty(definition))
            {
                tree.Insert(word, definition);
                AdicionarLista(word, definition);
                textBoxKey.Clear();
                textBoxValue.Clear();
            }
            else
            {
                MessageBox.Show("Por favor, insira tanto a palavra quanto a definição.");
            }
        }

        private void buttonOrder_Click(object sender, EventArgs e)
        {
            listBoxPalavras.Items.Clear();
            List<string> items = tree.GetInOrder();
            foreach (var item in items)
            {
                listBoxPalavras.Items.Add(item);
            }
        }

        private void buttonPostOrder_Click(object sender, EventArgs e)
        {
            listBoxPalavras.Items.Clear();
            List<string> items = tree.GetPostOrder();
            foreach (var item in items)
            {
                listBoxPalavras.Items.Add(item);
            }
        }

        private void buttonBuscarBinario_Click(object sender, EventArgs e)
        {
            string key = textBoxKey.Text;
            if (string.IsNullOrWhiteSpace(key))
            {
                MessageBox.Show("Por favor, insira uma palavra chave para buscar.");
                return;
            }

            string resultado = tree.Search(key);
            if (resultado == "Key not found")
            {
                MessageBox.Show("Palavra não encontrada.");
            }
            else
            {
                MessageBox.Show("Definição: " + resultado);
            }
        }

        private void ButtonRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPalavras.SelectedIndex != -1)
            {
                // Recupera a palavra chave do item selecionado para remover da árvore.
                string selectedItem = listBoxPalavras.SelectedItem.ToString();
                string key = selectedItem.Split(new[] { " – " }, StringSplitOptions.None)[0];

                // Remove da árvore binária e do ListBox.
                tree.Delete(key);
                listBoxPalavras.Items.RemoveAt(listBoxPalavras.SelectedIndex);
                MessageBox.Show("Item removido: " + selectedItem);
            }
            else if (!string.IsNullOrWhiteSpace(textBoxKey.Text))
            {
                string key = textBoxKey.Text;
                bool found = false;

                // Procura o item no ListBox que corresponde à palavra chave.
                for (int i = 0; i < listBoxPalavras.Items.Count; i++)
                {
                    if (listBoxPalavras.Items[i].ToString().StartsWith(key + " – "))
                    {
                        tree.Delete(key);
                        listBoxPalavras.Items.RemoveAt(i);
                        MessageBox.Show("Item removido: " + listBoxPalavras.Items[i]);
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    MessageBox.Show("Palavra não encontrada no dicionário.");
                }
            }
            else
            {
                MessageBox.Show("Selecione um item ou insira uma palavra chave para remover.");
            }
        }
    }
}
