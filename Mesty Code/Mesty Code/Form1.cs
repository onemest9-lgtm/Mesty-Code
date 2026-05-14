using System.Reflection.Emit;

namespace Mesty_Code
{
    public partial class Form1 : Form
    {
        private string currentFilePath = "";

        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(34, 34, 34);
            
            treeView1.NodeMouseDoubleClick += TreeView1_NodeMouseDoubleClick;
            
            fastColoredTextBox1.TextChanged += FastColoredTextBox1_TextChanged;




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void scintilla1_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void Developmentstore_Click(object sender, EventArgs e)
        {

            Form2 window2 = new Form2();
            window2.Show();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                // Показываем окно выбора папки на ПК
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    // Находим наше дерево внутри panel3 (обычно оно называется treeView1)
                    treeView1.Nodes.Clear();

                    // Берем информацию о выбранной папке
                    DirectoryInfo dirInfo = new DirectoryInfo(fbd.SelectedPath);

                    // Создаем главный (корневой) узел дерева с названием папки
                    TreeNode rootNode = new TreeNode(dirInfo.Name) { Tag = dirInfo.FullName };
                    treeView1.Nodes.Add(rootNode);

                    // Запускаем сканирование папки, чтобы заполнить дерево файлами
                    LoadFilesAndFolders(dirInfo.FullName, rootNode);

                    // Автоматически раскрываем список, чтобы сразу видеть файлы
                    rootNode.Expand();
                }
            }
        }

            private void LoadFilesAndFolders(string path, TreeNode parentNode)
        {
            try
            {
                // 1. Ищем все подпапки и добавляем их в дерево
                foreach (string directory in Directory.GetDirectories(path))
                {
                    DirectoryInfo dir = new DirectoryInfo(directory);
                    TreeNode dirNode = new TreeNode(dir.Name) { Tag = dir.FullName };
                    parentNode.Nodes.Add(dirNode);

                    // Повторяем процесс для вложенных папок (рекурсия)
                    LoadFilesAndFolders(directory, dirNode);
                }

                // 2. Ищем все файлы в текущей папке и добавляем их
                foreach (string file in Directory.GetFiles(path))
                {
                    FileInfo fileInfo = new FileInfo(file);
                    TreeNode fileNode = new TreeNode(fileInfo.Name) { Tag = fileInfo.FullName };
                    parentNode.Nodes.Add(fileNode);
                }
            }
            catch (Exception)
            {
                // Игнорируем ошибки доступа к системным или защищенным файлам
            }
        }

        private void TreeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            // Проверяем, что кликнули по файлу, а не по пустой папке
            if (e.Node.Tag != null && System.IO.File.Exists(e.Node.Tag.ToString()))
            {
                // Запоминаем путь к этому файлу
                currentFilePath = e.Node.Tag.ToString();

                // Считываем весь текст и выводим в редактор
                fastColoredTextBox1.Text = System.IO.File.ReadAllText(currentFilePath);

                // Обновляем заголовок окна программы
                this.Text = $"Mesty Code - {System.IO.Path.GetFileName(currentFilePath)}";
            }
        }

        private void FastColoredTextBox1_TextChanged(object sender, FastColoredTextBoxNS.TextChangedEventArgs e)
        {
            // Если файл уже был открыт и путь к нему известен — сохраняем изменения на лету
            if (!string.IsNullOrEmpty(currentFilePath) && System.IO.File.Exists(currentFilePath))
            {
                System.IO.File.WriteAllText(currentFilePath, fastColoredTextBox1.Text);
            }
        }

    }
}

