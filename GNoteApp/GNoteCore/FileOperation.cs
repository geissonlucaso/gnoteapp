namespace GNoteCore
{
    public class FileOperation
    {
        // Atributes.
        private string fileName = null!;
        private bool isFileSaved;


        // Properties.
        public string FileName { get => fileName; set => fileName = value; }
        public bool IsFileSaved { get => isFileSaved; set => isFileSaved = value; }


        // Methods.
        public void InitializeNewFile()
        {
            this.fileName = "Untitled.txt";
            this.isFileSaved = true;
        }

        public void SaveFile(string fileName, string[] lines)
        {

        }
    }
}
