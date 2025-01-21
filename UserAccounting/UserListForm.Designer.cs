namespace UserAccounting
{
    partial class UserListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewUsers = new DataGridView();
            refreshBtn = new Button();
            addBtn = new Button();
            deleteBtn = new Button();
            updateBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewUsers
            // 
            dataGridViewUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewUsers.Location = new Point(12, 48);
            dataGridViewUsers.Name = "dataGridViewUsers";
            dataGridViewUsers.Size = new Size(760, 465);
            dataGridViewUsers.TabIndex = 0;
            dataGridViewUsers.CellClick += dataGridViewUsers_CellClick;
            // 
            // refreshBtn
            // 
            refreshBtn.Location = new Point(672, 12);
            refreshBtn.Name = "refreshBtn";
            refreshBtn.Size = new Size(100, 30);
            refreshBtn.TabIndex = 1;
            refreshBtn.Text = "Обновить";
            refreshBtn.UseVisualStyleBackColor = true;
            refreshBtn.Click += refreshBtn_Click;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(12, 519);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(100, 30);
            addBtn.TabIndex = 2;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(118, 519);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(100, 30);
            deleteBtn.TabIndex = 3;
            deleteBtn.Text = "Удалить";
            deleteBtn.UseVisualStyleBackColor = true;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // updateBtn
            // 
            updateBtn.Location = new Point(224, 519);
            updateBtn.Name = "updateBtn";
            updateBtn.Size = new Size(150, 30);
            updateBtn.TabIndex = 4;
            updateBtn.Text = "Редактировать";
            updateBtn.UseVisualStyleBackColor = true;
            // 
            // UserListForm
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(784, 561);
            Controls.Add(updateBtn);
            Controls.Add(deleteBtn);
            Controls.Add(addBtn);
            Controls.Add(refreshBtn);
            Controls.Add(dataGridViewUsers);
            Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "UserListForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Учет пользователей";
            ((System.ComponentModel.ISupportInitialize)dataGridViewUsers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewUsers;
        private Button refreshBtn;
        private Button addBtn;
        private Button deleteBtn;
        private Button updateBtn;
    }
}