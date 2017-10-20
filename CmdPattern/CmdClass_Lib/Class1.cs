using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CmdClass_Lib
{

    //command abstract class
    public abstract class Command
    {
        protected WriterReceiver reciever;

        public abstract void Execute();
        public abstract string Unexecute();
    }

    //concrete command class
    public class WriterCommand : Command
    {
        private string curr_text;
        private WriterReceiver WRec;

        public WriterCommand(string textb, WriterReceiver new_receiver)
        {
            curr_text = textb;
            WRec = new_receiver;
        }

        public override void Execute()
        {
            WRec.WriteCheckpoint(curr_text);
        }

        public override string Unexecute()
        {
            return WRec.GetWritten;
        }
    }

    //receiver class
    public class WriterReceiver
    {
        private string curr_text;

        public void WriteCheckpoint(string new_text)
        {
            curr_text = new_text;
        }

        public string GetWritten
        {
            get { return curr_text; }
        }
    }

    //invoker class
    public class User
    {
        private WriterReceiver WRec;
        private List<Command> commands;
        private int curr_index;

        public User()
        {
            WRec = new WriterReceiver();
            commands = new List<Command>();
            curr_index = 0;
        }

        public string Redo()
        {
            if (curr_index < commands.Count - 1)
            {
                curr_index++;
                Command cmd = commands[curr_index];
                return cmd.Unexecute();
            }

            return "Error Redoing";
        }

        public string Undo()
        {
            if (curr_index > 0)
            {
                curr_index--;
                Command cmd = commands.ElementAt<Command>(curr_index);
                return cmd.Unexecute();
            }

            return "Error Undoing";
        }

        public void Write(string curr_text)
        {
            Command cmd = new WriterCommand(curr_text, WRec);
            cmd.Execute();

            //add the command
            commands.Add(cmd);

            curr_index++;
        }
    }

}
