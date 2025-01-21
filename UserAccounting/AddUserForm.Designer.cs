namespace UserAccounting
{
    partial class AddUserForm
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
            label1 = new Label();
            label2 = new Label();
            userNameInput = new TextBox();
            userAgeInput = new NumericUpDown();
            addBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)userAgeInput).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 48);
            label1.Name = "label1";
            label1.Size = new Size(155, 22);
            label1.TabIndex = 0;
            label1.Text = "Имя пользователя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 119);
            label2.Name = "label2";
            label2.Size = new Size(187, 22);
            label2.TabIndex = 1;
            label2.Text = "Возраст пользователя";
            // 
            // userNameInput
            // 
            userNameInput.Location = new Point(50, 73);
            userNameInput.Name = "userNameInput";
            userNameInput.Size = new Size(200, 29);
            userNameInput.TabIndex = 2;
            // 
            // userAgeInput
            // 
            userAgeInput.Location = new Point(50, 144);
            userAgeInput.Name = "userAgeInput";
            userAgeInput.Size = new Size(200, 29);
            userAgeInput.TabIndex = 3;
            // 
            // addBtn
            // 
            addBtn.Location = new Point(100, 219);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(100, 30);
            addBtn.TabIndex = 5;
            addBtn.Text = "Добавить";
            addBtn.UseVisualStyleBackColor = true;
            addBtn.Click += addBtn_Click;
            // 
            // AddUserForm
            // 
            AutoScaleDimensions = new SizeF(12F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(284, 261);
            Controls.Add(addBtn);
            Controls.Add(userAgeInput);
            Controls.Add(userNameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(5, 4, 5, 4);
            MaximizeBox = false;
            Name = "AddUserForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Добавление пользователя";
            ((System.ComponentModel.ISupportInitialize)userAgeInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox userNameInput;
        private NumericUpDown userAgeInput;
        private Button addBtn;
    }
}