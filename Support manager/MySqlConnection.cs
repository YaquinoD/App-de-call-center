using System;

namespace Support_manager
{
    internal class MySqlConnection
    {
        private string connetionString;

        public MySqlConnection(string connetionString)
        {
            this.connetionString = connetionString;
        }

        internal void Open()
        {
            throw new NotImplementedException();
        }

        internal void Close()
        {
            throw new NotImplementedException();
        }
    }
}