
using Newtonsoft.Json;

namespace NotesApp
{
    internal class JsonWizard
    {
        public static SavedNotesData ReadJson(string jsonPath)
        {
            SavedNotesData snd = new();

            // yeah, this entire if statement is not really reading, should've put it somewhere else...
            if (!File.Exists(jsonPath)) {
                File.Create(jsonPath).Close();

                string[] _welcome_title = new string[1];
                _welcome_title[0] = "Notes App Introduction! Click 'Read' button.";
                string[] _welcome_message = new string[1];
                _welcome_message[0] = "Buttons:\r\n" +
                                      " - New: creates a new note\r\n" +
                                      " - Save: saves your note\r\n" +
                                      " - Read: displays Title and Message of your saved note\r\n" +
                                      " - Delete: deletes your selected note";
                snd.Title = _welcome_title;
                snd.Message = _welcome_message;
                //snd.Title = new string[0];
                //snd.Message = new string[0];

                SaveToJson(jsonPath, snd);
            }

            try
            {
                string jsonData;
                using (StreamReader r = new(jsonPath))
                {
                    jsonData = r.ReadToEnd();
                }

                snd = JsonConvert.DeserializeObject<SavedNotesData>(jsonData);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR | JsonWizard > ReadJson()");
            }
            return snd;
        }

        public static void SaveToJson(string jsonPath, SavedNotesData snd)
        {
            try {
                var notesToSave = JsonConvert.SerializeObject(snd, Formatting.Indented);

                using StreamWriter writer = new(jsonPath);
                writer.Write(notesToSave);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "ERROR | JsonWizard > SaveToJson()");
            }
        }


        public class SavedNotesData
        {
            public string[] Title { get; set; }
            public string[] Message { get; set; }
        }
    }
}
