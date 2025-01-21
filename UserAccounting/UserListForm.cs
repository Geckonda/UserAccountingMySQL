using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccounting.Repositories;

namespace UserAccounting
{
    public partial class UserListForm : Form
    {
        private readonly UserRepository _userRepository;
        public UserListForm(UserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
            LoadUsers();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            LoadUsers();
        }

        private void LoadUsers()
        {
            // Получаем список пользователей из репозитория
            var users = _userRepository.GetAll();

            // Привязываем данные к DataGridView
            dataGridViewUsers.DataSource = null; // Сбрасываем источник данных
            dataGridViewUsers.DataSource = users; // Заполняем
        }

        private void dataGridViewUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Проверяем, что кликнули не по заголовку
            {
                dataGridViewUsers.Rows[e.RowIndex].Selected = true;
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            AddUserForm form = new AddUserForm(_userRepository);
            form.Show();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Проверяем, что выделен только один ряд
            if (dataGridViewUsers.SelectedRows.Count == 1)
            {
                // Получаем этот ряд в переменную
                var selectedRow = dataGridViewUsers.SelectedRows[0];
                // Достаем id 
                var userId = selectedRow.Cells["Id"].Value;
                // Валидируем id на всякий случай
                if (userId != null && int.TryParse(userId.ToString(), out int id))
                {
                    try
                    {
                        // Здесь вызовите метод удаления пользователя
                        _userRepository.Delete(id);

                        // Обновляем таблицу после удаления
                        LoadUsers();
                        MessageBox.Show("Пользователь успешно удален.");
                    }
                    catch
                    {
                        MessageBox.Show("Произошла ошибка!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
