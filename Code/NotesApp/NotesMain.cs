/*
Made by @StreakyFly | My first C# project
Followed a tutorial by SaeThunder: https://www.youtube.com/watch?v=8vAx0kObdps
I also added methods to locally store saved notes, so the app is actually useful.
*/


using System.Data;
using static NotesApp.JsonWizard;

namespace NotesApp
{
    public partial class NotesMain : Form
    {
        DataTable table = new();
        private readonly string _savedNotesJsonName = "saved_notes.json";

        public NotesMain()
        {
            InitializeComponent();
        }

        public string getJsonPath()
        {
            string currDir = AppDomain.CurrentDomain.BaseDirectory;
            string jsonPath = Path.Combine(currDir, _savedNotesJsonName);
            return jsonPath;
        }

        private void NotesMain_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(string));
            table.Columns.Add("Message", typeof(string));

            NotesViewGrid.DataSource = table;

            NotesViewGrid.Columns["Message"].Visible = false;
            NotesViewGrid.Columns["Title"].Width = 257;

            EmptyBoxError.Visible = false;

            JsonWizard.SavedNotesData snd = JsonWizard.ReadJson(getJsonPath());
            for (int i = 0; i<snd.Title.Length; i++)
            {
                table.Rows.Add(snd.Title[i], snd.Message[i]);
            }
        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();
            EmptyBoxError.Visible = false;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (textTitle.Text != "" && textMessage.Text != "")
            {
                EmptyBoxError.Visible = false;
                table.Rows.Add(textTitle.Text, textMessage.Text);

                SavedNotesData currNotes = ReadJson(getJsonPath());
                string[] titles = currNotes.Title;
                string[] messages = currNotes.Message;
                Array.Resize(ref titles, currNotes.Title.Length + 1);
                Array.Resize(ref messages, currNotes.Message.Length + 1);
                titles[^1] = textTitle.Text;  // "titles.Length - 1" = "^1", because ^ means the index starts from the end, not beginning
                messages[^1] = textMessage.Text;
                SavedNotesData snd = new()
                {
                    Title = titles,
                    Message = messages
                };

                JsonWizard.SaveToJson(getJsonPath(), snd);

                textTitle.Clear();
                textMessage.Clear();
            }
            else
            {
                EmptyBoxError.Visible = true;
            }
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            EmptyBoxError.Visible = false;
            if (NotesViewGrid.CurrentCell != null)
            {
                int index = NotesViewGrid.CurrentCell.RowIndex;

                if (index >= 0)
                {
                    textTitle.Text = table.Rows[index]["Title"].ToString();
                    textMessage.Text = table.Rows[index]["Message"].ToString();
                }
            }
            else
            {
                MessageBox.Show("You don't have any saved notes!", "No notes");
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            EmptyBoxError.Visible = false;
            if (NotesViewGrid.CurrentCell == null)
            {
                MessageBox.Show("You don't have any saved notes!", "No notes");
            }
            else
            {
                int indexToRemove = NotesViewGrid.CurrentCell.RowIndex;

                table.Rows.RemoveAt(indexToRemove);

                JsonWizard.SavedNotesData snd = JsonWizard.ReadJson(getJsonPath());

                snd.Title = snd.Title.Where((source, index) => index != indexToRemove).ToArray();
                snd.Message = snd.Message.Where((source, index) => index != indexToRemove).ToArray();

                JsonWizard.SaveToJson(getJsonPath(), snd);
            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e) { }

    }
}