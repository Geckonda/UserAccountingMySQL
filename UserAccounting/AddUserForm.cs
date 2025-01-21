using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserAccounting.Models;
using UserAccounting.Repositories;

namespace UserAccounting
{
    public partial class AddUserForm : Form
    {
        private readonly UserRepository _userRepository;
        public AddUserForm(UserRepository userRepository)
        {
            InitializeComponent();
            _userRepository = userRepository;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text == "")
            {
                MessageBox.Show("Имя не должно быть пустым.",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            try
            {

                User user = new()
                {
                    Name = userNameInput.Text,
                    Age = Convert.ToInt32(userAgeInput.Value),
                };
                _userRepository.Add(user);
                MessageBox.Show("Пользователь успешно добавлен!");
            }
            catch (Exception)
            {
                MessageBox.Show("Произошла ошибка!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
