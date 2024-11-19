namespace GNoteApp
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
            menuBar = new MenuStrip();
            fileMenu = new ToolStripMenuItem();
            newFileMenu = new ToolStripMenuItem();
            openFileMenu = new ToolStripMenuItem();
            saveFileMenu = new ToolStripMenuItem();
            saveAsFileMenu = new ToolStripMenuItem();
            toolStripSeparator4 = new ToolStripSeparator();
            exitFileMenu = new ToolStripMenuItem();
            editMenu = new ToolStripMenuItem();
            undoEditMenu = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            cutEditMenu = new ToolStripMenuItem();
            copyEditMenu = new ToolStripMenuItem();
            pasteEditMenu = new ToolStripMenuItem();
            deleteEditMenu = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            findEditMenu = new ToolStripMenuItem();
            findNextEditMenu = new ToolStripMenuItem();
            replaceEditMenu = new ToolStripMenuItem();
            goToEditMenu = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            selectAllEditMenu = new ToolStripMenuItem();
            timeDateEditMenu = new ToolStripMenuItem();
            formatMenu = new ToolStripMenuItem();
            wordWrapFormatMenu = new ToolStripMenuItem();
            fontFormatMenu = new ToolStripMenuItem();
            statusBarViewMenu = new ToolStripMenuItem();
            statusBarToolStripMenuItem = new ToolStripMenuItem();
            helpMenu = new ToolStripMenuItem();
            viewHelpHelpMenu = new ToolStripMenuItem();
            aboutNotepadHelpMenu = new ToolStripMenuItem();
            txtArea = new RichTextBox();
            menuBar.SuspendLayout();
            SuspendLayout();
            // 
            // menuBar
            // 
            menuBar.Items.AddRange(new ToolStripItem[] { fileMenu, editMenu, formatMenu, statusBarViewMenu, helpMenu });
            menuBar.Location = new Point(0, 0);
            menuBar.Name = "menuBar";
            menuBar.Size = new Size(800, 24);
            menuBar.TabIndex = 0;
            menuBar.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            fileMenu.DropDownItems.AddRange(new ToolStripItem[] { newFileMenu, openFileMenu, saveFileMenu, saveAsFileMenu, toolStripSeparator4, exitFileMenu });
            fileMenu.Name = "fileMenu";
            fileMenu.Size = new Size(37, 20);
            fileMenu.Text = "File";
            // 
            // newFileMenu
            // 
            newFileMenu.Name = "newFileMenu";
            newFileMenu.ShortcutKeys = Keys.Control | Keys.N;
            newFileMenu.Size = new Size(155, 22);
            newFileMenu.Text = "New";
            newFileMenu.Click += newFileMenu_Click;
            // 
            // openFileMenu
            // 
            openFileMenu.Name = "openFileMenu";
            openFileMenu.ShortcutKeys = Keys.Control | Keys.O;
            openFileMenu.Size = new Size(155, 22);
            openFileMenu.Text = "Open...";
            // 
            // saveFileMenu
            // 
            saveFileMenu.Name = "saveFileMenu";
            saveFileMenu.ShortcutKeys = Keys.Control | Keys.S;
            saveFileMenu.Size = new Size(155, 22);
            saveFileMenu.Text = "Save";
            // 
            // saveAsFileMenu
            // 
            saveAsFileMenu.Name = "saveAsFileMenu";
            saveAsFileMenu.Size = new Size(155, 22);
            saveAsFileMenu.Text = "Save As...";
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new Size(152, 6);
            // 
            // exitFileMenu
            // 
            exitFileMenu.Name = "exitFileMenu";
            exitFileMenu.Size = new Size(155, 22);
            exitFileMenu.Text = "Exit";
            // 
            // editMenu
            // 
            editMenu.DropDownItems.AddRange(new ToolStripItem[] { undoEditMenu, toolStripSeparator1, cutEditMenu, copyEditMenu, pasteEditMenu, deleteEditMenu, toolStripSeparator2, findEditMenu, findNextEditMenu, replaceEditMenu, goToEditMenu, toolStripSeparator3, selectAllEditMenu, timeDateEditMenu });
            editMenu.Name = "editMenu";
            editMenu.Size = new Size(39, 20);
            editMenu.Text = "Edit";
            // 
            // undoEditMenu
            // 
            undoEditMenu.Name = "undoEditMenu";
            undoEditMenu.ShortcutKeys = Keys.Control | Keys.Z;
            undoEditMenu.Size = new Size(167, 22);
            undoEditMenu.Text = "Undo";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(164, 6);
            // 
            // cutEditMenu
            // 
            cutEditMenu.Name = "cutEditMenu";
            cutEditMenu.ShortcutKeys = Keys.Control | Keys.X;
            cutEditMenu.Size = new Size(167, 22);
            cutEditMenu.Text = "Cut";
            // 
            // copyEditMenu
            // 
            copyEditMenu.Name = "copyEditMenu";
            copyEditMenu.ShortcutKeys = Keys.Control | Keys.C;
            copyEditMenu.Size = new Size(167, 22);
            copyEditMenu.Text = "Copy";
            // 
            // pasteEditMenu
            // 
            pasteEditMenu.Name = "pasteEditMenu";
            pasteEditMenu.ShortcutKeys = Keys.Control | Keys.V;
            pasteEditMenu.Size = new Size(167, 22);
            pasteEditMenu.Text = "Paste";
            // 
            // deleteEditMenu
            // 
            deleteEditMenu.Name = "deleteEditMenu";
            deleteEditMenu.ShortcutKeys = Keys.Delete;
            deleteEditMenu.Size = new Size(167, 22);
            deleteEditMenu.Text = "Delete";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(164, 6);
            // 
            // findEditMenu
            // 
            findEditMenu.Name = "findEditMenu";
            findEditMenu.ShortcutKeys = Keys.Control | Keys.F;
            findEditMenu.Size = new Size(167, 22);
            findEditMenu.Text = "Find...";
            // 
            // findNextEditMenu
            // 
            findNextEditMenu.Name = "findNextEditMenu";
            findNextEditMenu.ShortcutKeys = Keys.F3;
            findNextEditMenu.Size = new Size(167, 22);
            findNextEditMenu.Text = "Find Next";
            // 
            // replaceEditMenu
            // 
            replaceEditMenu.Name = "replaceEditMenu";
            replaceEditMenu.ShortcutKeys = Keys.Control | Keys.H;
            replaceEditMenu.Size = new Size(167, 22);
            replaceEditMenu.Text = "Replace...";
            // 
            // goToEditMenu
            // 
            goToEditMenu.Name = "goToEditMenu";
            goToEditMenu.ShortcutKeys = Keys.Control | Keys.G;
            goToEditMenu.Size = new Size(167, 22);
            goToEditMenu.Text = "Go To...";
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(164, 6);
            // 
            // selectAllEditMenu
            // 
            selectAllEditMenu.Name = "selectAllEditMenu";
            selectAllEditMenu.ShortcutKeys = Keys.Control | Keys.A;
            selectAllEditMenu.Size = new Size(167, 22);
            selectAllEditMenu.Text = "Select All";
            // 
            // timeDateEditMenu
            // 
            timeDateEditMenu.Name = "timeDateEditMenu";
            timeDateEditMenu.ShortcutKeys = Keys.F5;
            timeDateEditMenu.Size = new Size(167, 22);
            timeDateEditMenu.Text = "Time/Date";
            // 
            // formatMenu
            // 
            formatMenu.DropDownItems.AddRange(new ToolStripItem[] { wordWrapFormatMenu, fontFormatMenu });
            formatMenu.Name = "formatMenu";
            formatMenu.Size = new Size(57, 20);
            formatMenu.Text = "Format";
            // 
            // wordWrapFormatMenu
            // 
            wordWrapFormatMenu.Name = "wordWrapFormatMenu";
            wordWrapFormatMenu.Size = new Size(134, 22);
            wordWrapFormatMenu.Text = "Word Wrap";
            // 
            // fontFormatMenu
            // 
            fontFormatMenu.Name = "fontFormatMenu";
            fontFormatMenu.Size = new Size(134, 22);
            fontFormatMenu.Text = "Font...";
            // 
            // statusBarViewMenu
            // 
            statusBarViewMenu.DropDownItems.AddRange(new ToolStripItem[] { statusBarToolStripMenuItem });
            statusBarViewMenu.Name = "statusBarViewMenu";
            statusBarViewMenu.Size = new Size(44, 20);
            statusBarViewMenu.Text = "View";
            // 
            // statusBarToolStripMenuItem
            // 
            statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            statusBarToolStripMenuItem.Size = new Size(126, 22);
            statusBarToolStripMenuItem.Text = "Status Bar";
            // 
            // helpMenu
            // 
            helpMenu.DropDownItems.AddRange(new ToolStripItem[] { viewHelpHelpMenu, aboutNotepadHelpMenu });
            helpMenu.Name = "helpMenu";
            helpMenu.Size = new Size(44, 20);
            helpMenu.Text = "Help";
            // 
            // viewHelpHelpMenu
            // 
            viewHelpHelpMenu.Name = "viewHelpHelpMenu";
            viewHelpHelpMenu.Size = new Size(156, 22);
            viewHelpHelpMenu.Text = "View Help";
            // 
            // aboutNotepadHelpMenu
            // 
            aboutNotepadHelpMenu.Name = "aboutNotepadHelpMenu";
            aboutNotepadHelpMenu.Size = new Size(156, 22);
            aboutNotepadHelpMenu.Text = "About Notepad";
            // 
            // txtArea
            // 
            txtArea.Dock = DockStyle.Fill;
            txtArea.Location = new Point(0, 24);
            txtArea.Name = "txtArea";
            txtArea.Size = new Size(800, 426);
            txtArea.TabIndex = 1;
            txtArea.Text = "";
            txtArea.TextChanged += txtArea_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtArea);
            Controls.Add(menuBar);
            MainMenuStrip = menuBar;
            Name = "Form1";
            Text = "GNote";
            Load += Form1_Load;
            menuBar.ResumeLayout(false);
            menuBar.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuBar;
        private ToolStripMenuItem fileMenu;
        private ToolStripMenuItem newFileMenu;
        private ToolStripMenuItem openFileMenu;
        private ToolStripMenuItem saveFileMenu;
        private ToolStripMenuItem saveAsFileMenu;
        private ToolStripMenuItem editMenu;
        private ToolStripMenuItem formatMenu;
        private ToolStripMenuItem statusBarViewMenu;
        private ToolStripMenuItem helpMenu;
        private RichTextBox txtArea;
        private ToolStripMenuItem undoEditMenu;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem cutEditMenu;
        private ToolStripMenuItem copyEditMenu;
        private ToolStripMenuItem pasteEditMenu;
        private ToolStripMenuItem deleteEditMenu;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem findEditMenu;
        private ToolStripMenuItem findNextEditMenu;
        private ToolStripMenuItem replaceEditMenu;
        private ToolStripMenuItem goToEditMenu;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem selectAllEditMenu;
        private ToolStripMenuItem timeDateEditMenu;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem exitFileMenu;
        private ToolStripMenuItem wordWrapFormatMenu;
        private ToolStripMenuItem fontFormatMenu;
        private ToolStripMenuItem statusBarToolStripMenuItem;
        private ToolStripMenuItem viewHelpHelpMenu;
        private ToolStripMenuItem aboutNotepadHelpMenu;
    }
}
