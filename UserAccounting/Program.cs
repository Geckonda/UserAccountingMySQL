using MySql.Data.MySqlClient;
using UserAccounting.Repositories;

namespace UserAccounting
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            // �������� ����� ��
            const string database = "GregRom";

            //������ �����������
            string connectionString = $"Server=localhost;Database={database};User=root;Password=;Port=3306;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open(); // �������� ����������
                    UserRepository userRepository = new UserRepository(connection); // ������� ����������� �������������
                    ApplicationConfiguration.Initialize();
                    Application.Run(new UserListForm(userRepository));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}