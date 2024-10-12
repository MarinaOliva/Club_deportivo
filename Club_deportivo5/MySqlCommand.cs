namespace club_Deportivo
{
    internal class MySqlCommand
    {
        private string query;
        private MySqlConnection connection;

        public MySqlCommand(string query, MySqlConnection connection)
        {
            this.query = query;
            this.connection = connection;
        }
    }
}