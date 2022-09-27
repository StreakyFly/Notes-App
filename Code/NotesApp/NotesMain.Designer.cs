namespace NotesApp
{
    partial class NotesMain
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
            this.EmptyBoxError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textTitle = new System.Windows.Forms.TextBox();
            this.textMessage = new System.Windows.Forms.TextBox();
            this.NotesViewGrid = new System.Windows.Forms.DataGridView();
            this.buttonNew = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NotesViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // EmptyBoxError
            // 
            this.EmptyBoxError.BackColor = System.Drawing.Color.Yellow;
            this.EmptyBoxError.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.EmptyBoxError.ForeColor = System.Drawing.Color.Red;
            this.EmptyBoxError.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EmptyBoxError.Location = new System.Drawing.Point(247, 337);
            this.EmptyBoxError.Multiline = true;
            this.EmptyBoxError.Name = "EmptyBoxError";
            this.EmptyBoxError.ReadOnly = true;
            this.EmptyBoxError.ShortcutsEnabled = false;
            this.EmptyBoxError.Size = new System.Drawing.Size(132, 42);
            this.EmptyBoxError.TabIndex = 10;
            this.EmptyBoxError.Text = "Title/Message box cannot be empty!";
            this.EmptyBoxError.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(62, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Title";
            // 
            // textTitle
            // 
            this.textTitle.BackColor = System.Drawing.SystemColors.Window;
            this.textTitle.Location = new System.Drawing.Point(62, 82);
            this.textTitle.Name = "textTitle";
            this.textTitle.Size = new System.Drawing.Size(317, 23);
            this.textTitle.TabIndex = 2;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(62, 151);
            this.textMessage.Multiline = true;
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(317, 166);
            this.textMessage.TabIndex = 3;
            // 
            // NotesViewGrid
            // 
            this.NotesViewGrid.AllowUserToAddRows = false;
            this.NotesViewGrid.AllowUserToDeleteRows = false;
            this.NotesViewGrid.AllowUserToResizeColumns = false;
            this.NotesViewGrid.AllowUserToResizeRows = false;
            this.NotesViewGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.NotesViewGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NotesViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NotesViewGrid.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.NotesViewGrid.Location = new System.Drawing.Point(457, 57);
            this.NotesViewGrid.Name = "NotesViewGrid";
            this.NotesViewGrid.ReadOnly = true;
            this.NotesViewGrid.RowHeadersVisible = false;
            this.NotesViewGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.NotesViewGrid.RowTemplate.Height = 25;
            this.NotesViewGrid.Size = new System.Drawing.Size(260, 260);
            this.NotesViewGrid.TabIndex = 4;
            // 
            // buttonNew
            // 
            this.buttonNew.BackColor = System.Drawing.Color.Cyan;
            this.buttonNew.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonNew.Location = new System.Drawing.Point(62, 343);
            this.buttonNew.Name = "buttonNew";
            this.buttonNew.Size = new System.Drawing.Size(75, 30);
            this.buttonNew.TabIndex = 5;
            this.buttonNew.Text = "New";
            this.buttonNew.UseVisualStyleBackColor = false;
            this.buttonNew.Click += new System.EventHandler(this.buttonNew_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonDelete.Location = new System.Drawing.Point(551, 343);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 30);
            this.buttonDelete.TabIndex = 6;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonRead
            // 
            this.buttonRead.BackColor = System.Drawing.Color.Yellow;
            this.buttonRead.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonRead.Location = new System.Drawing.Point(457, 343);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(75, 30);
            this.buttonRead.TabIndex = 7;
            this.buttonRead.Text = "Read";
            this.buttonRead.UseVisualStyleBackColor = false;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.Chartreuse;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonSave.Location = new System.Drawing.Point(156, 343);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 30);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Message";
            // 
            // NotesMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 441);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmptyBoxError);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonNew);
            this.Controls.Add(this.NotesViewGrid);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.textTitle);
            this.Controls.Add(this.label1);
            this.Name = "NotesMain";
            this.Text = "Notes App by @StreakyFly | First C# project";
            this.Load += new System.EventHandler(this.NotesMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NotesViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textTitle;
        private TextBox textMessage;
        private DataGridView NotesViewGrid;
        private Button buttonNew;
        private Button buttonDelete;
        private Button buttonRead;
        private Button buttonSave;
        private TextBox EmptyBoxError;
    }
}