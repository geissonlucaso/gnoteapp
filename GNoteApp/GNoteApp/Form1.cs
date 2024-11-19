using GNoteCore;

namespace GNoteApp
{
    public partial class Form1 : Form
    {

        FileOperation fileOperation;

        public Form1()
        {
            InitializeComponent();
            fileOperation = new FileOperation();
            fileOperation.InitializeNewFile();
            this.Text = fileOperation.FileName;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newFileMenu_Click(object sender, EventArgs e)
        {
            // New file menu item click.
            // if the file IS saved Initialize new file status.
            // If the file IS NOT saved ask to save the file.
            if (fileOperation.IsFileSaved)
            {
                // New file status.
                fileOperation.InitializeNewFile();
                txtArea.Text = "";
                UpdateView();
            }
            else
            {
                DialogResult result = MessageBox.Show(
                                        $"You need to save some changes to {fileOperation.FileName}",
                                        "Notepad",
                                        MessageBoxButtons.YesNoCancel,
                                        MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    if (fileOperation.FileName.Contains("Untitled"))
                    {
                        SaveFileDialog newFileSave = new SaveFileDialog();
                        newFileSave.Filter = "Text(*.txt)|*.txt";
                        if (newFileSave.ShowDialog() == DialogResult.OK)
                        {
                            // File is to be saved for the first time.
                            fileOperation.SaveFile(newFileSave.FileName, txtArea.Lines);
                            UpdateView();
                        }
                        else
                        {
                            // File aready saved. Use name from fileOperation.
                            fileOperation.SaveFile(fileOperation.FileName, txtArea.Lines);
                            UpdateView();
                        }
                    }
                }
                else if (result == DialogResult.No)
                {
                    // When user select not to save, Initialize new file.
                    txtArea.Text = "";
                    fileOperation.InitializeNewFile();
                    UpdateView();
                }
            }
        }

        private void UpdateView()
        {
            this.Text = !fileOperation.IsFileSaved ? fileOperation.FileName + "*" : fileOperation.FileName;
        }

        private void txtArea_TextChanged(object sender, EventArgs e)
        {
            fileOperation.IsFileSaved = false;
            UpdateView();
        }
    }
}
