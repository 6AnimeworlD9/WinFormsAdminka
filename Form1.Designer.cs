namespace WinFormsAdminka
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tableMoneyAccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.UpdBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.ReloadDataGrid = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMoneyAccountsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(33, 109);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(803, 842);
            this.dataGridView1.TabIndex = 0;
            // 
            // tableMoneyAccountsBindingSource
            // 
            this.tableMoneyAccountsBindingSource.DataSource = typeof(WinFormsAdminka.TableMoneyAccounts);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.button1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(33, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "Заполнить тестовыми данными";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.BackColor = System.Drawing.Color.GreenYellow;
            this.AddBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.AddBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.AddBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.AddBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.AddBtn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AddBtn.Location = new System.Drawing.Point(33, 69);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(121, 34);
            this.AddBtn.TabIndex = 2;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = false;
            // 
            // UpdBtn
            // 
            this.UpdBtn.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.UpdBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.UpdBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.UpdBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.UpdBtn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpdBtn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.UpdBtn.Location = new System.Drawing.Point(160, 69);
            this.UpdBtn.Name = "UpdBtn";
            this.UpdBtn.Size = new System.Drawing.Size(121, 34);
            this.UpdBtn.TabIndex = 3;
            this.UpdBtn.Text = "Изменить";
            this.UpdBtn.UseVisualStyleBackColor = false;
            // 
            // DelBtn
            // 
            this.DelBtn.BackColor = System.Drawing.Color.Red;
            this.DelBtn.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.DelBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.DelBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.DelBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.DelBtn.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DelBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DelBtn.Location = new System.Drawing.Point(287, 69);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(121, 34);
            this.DelBtn.TabIndex = 4;
            this.DelBtn.Text = "Удалить";
            this.DelBtn.UseVisualStyleBackColor = false;
            // 
            // ReloadDataGrid
            // 
            this.ReloadDataGrid.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ReloadDataGrid.FlatAppearance.BorderColor = System.Drawing.Color.Lime;
            this.ReloadDataGrid.FlatAppearance.CheckedBackColor = System.Drawing.Color.Chartreuse;
            this.ReloadDataGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.ForestGreen;
            this.ReloadDataGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.GreenYellow;
            this.ReloadDataGrid.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ReloadDataGrid.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ReloadDataGrid.Location = new System.Drawing.Point(715, 69);
            this.ReloadDataGrid.Name = "ReloadDataGrid";
            this.ReloadDataGrid.Size = new System.Drawing.Size(121, 34);
            this.ReloadDataGrid.TabIndex = 5;
            this.ReloadDataGrid.Text = "Обновить";
            this.ReloadDataGrid.UseVisualStyleBackColor = false;
            this.ReloadDataGrid.Click += new System.EventHandler(this.ReloadDataGrid_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(872, 972);
            this.Controls.Add(this.ReloadDataGrid);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.UpdBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Панель администрирования БД";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableMoneyAccountsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private BindingSource tableMoneyAccountsBindingSource;
        private Button AddBtn;
        private Button UpdBtn;
        private Button DelBtn;
        private Button ReloadDataGrid;
    }
}