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
            BinaryTree tree = new BinaryTree();

            string pdfPath = "C:/dicionario-arretado.pdf";
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
                            //listBoxPalavras.Items.Add(word + " – " + definition);
                            AdicionarLista(word, definition);
                        }
                    }
                }
            }
        }

        private void buttonPreOrder_Click(object sender, EventArgs e)
        {
            BinaryTree tree = new BinaryTree();

            string pdfPath = "C:/dicionario-arretado.pdf";
            ExtractWordsAndInsertIntoTree(pdfPath, tree);
            tree.PrintPreOrder();
        }
        public void AdicionarLista(string word, string definition)
        {
            //listBoxPalavras listagem;
            listBoxPalavras.Items.Add(word + " – " + definition);
        }
    }
}
