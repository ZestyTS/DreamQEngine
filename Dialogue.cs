using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SQLite;

namespace DreamQEngine
{
    public class Dialogue
    {
        //The text of the dialogue presented
        protected string mText;

        //The NPC saying this dialogue
        protected Actor mActor;

        //The choices presented to you at the end of the dialogue
        protected Option[] mChoices;

        public Dialogue(int dialogueRef, SQLiteConnection conn)
        {
            SQLiteDataReader reader = new SQLiteCommand("Select * From Dialogue WHERE id = " + dialogueRef + ";", conn).ExecuteReader();

            DataTable dialogueTable = new DataTable();
            dialogueTable.Load(reader);

            DataView dialogueView = new DataView(dialogueTable);

            if (dialogueView.Count > 0)
            {
                mText = dialogueView[0]["text"].ToString();
                mActor = new Actor(Convert.ToInt32(dialogueView[0]["actorId"]), conn);

                reader = new SQLiteCommand("Select * From Options WHERE dialogueId = " + dialogueRef + ";", conn).ExecuteReader();
                DataTable optionTable = new DataTable();
                optionTable.Load(reader);

                DataView optionView = new DataView(optionTable);

                mChoices = new Option[optionView.Count];

                for(int i = 0; i < optionView.Count; i++)
                {
                    string optionText = optionView[i]["actualtext"].ToString();
                    string optionDisplay = optionView[i]["displayText"].ToString();
                    int outcomeType = Convert.ToInt32(optionView[i]["outcomeType"]);
                    int outcomeId = Convert.ToInt32(optionView[i]["outcomeId"]);
                    mChoices[i] = new Option(optionText, optionDisplay, outcomeType, outcomeId);
                }
            }
        }

        public Dialogue getOutcome(Outcome outcome)
        {
            SQLiteConnection conn = new SQLiteConnection(String.Format("Data Source={0}", "C:/theboywholived.db"));
            conn.Open();
            return new Dialogue(outcome.reference, conn);
        }

        public string text
        {
            set { mText = value; }
            get { return mText; }
        }

        public Option[] choices
        {
            set { mChoices = value; }
            get { return mChoices; }
        }

        public Actor actor
        {
            set { mActor = value; }
            get { return mActor; }
        }
    }
}