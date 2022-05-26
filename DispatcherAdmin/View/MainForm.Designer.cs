
namespace DispatcherAdmin
{
    partial class MainForm
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
            this.ViewAutobus = new System.Windows.Forms.TabPage();
            this.AutobusDataGridView = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Message = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SendBtn = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.AutobusLB = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel6 = new System.Windows.Forms.Panel();
            this.AutobusTB = new System.Windows.Forms.TextBox();
            this.AddAutobusBtn = new System.Windows.Forms.Button();
            this.DeleteAutobusBtn = new System.Windows.Forms.Button();
            this.ViewAutobus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutobusDataGridView)).BeginInit();
            this.panel5.SuspendLayout();
            this.Message.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // ViewAutobus
            // 
            this.ViewAutobus.Controls.Add(this.panel6);
            this.ViewAutobus.Controls.Add(this.panel5);
            this.ViewAutobus.Location = new System.Drawing.Point(4, 25);
            this.ViewAutobus.Margin = new System.Windows.Forms.Padding(0);
            this.ViewAutobus.Name = "ViewAutobus";
            this.ViewAutobus.Padding = new System.Windows.Forms.Padding(5, 20, 5, 0);
            this.ViewAutobus.Size = new System.Drawing.Size(905, 486);
            this.ViewAutobus.TabIndex = 2;
            this.ViewAutobus.Text = "Посмотреть автобусы";
            this.ViewAutobus.UseVisualStyleBackColor = true;
            // 
            // AutobusDataGridView
            // 
            this.AutobusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutobusDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutobusDataGridView.Location = new System.Drawing.Point(0, 0);
            this.AutobusDataGridView.Name = "AutobusDataGridView";
            this.AutobusDataGridView.Size = new System.Drawing.Size(716, 466);
            this.AutobusDataGridView.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.DeleteAutobusBtn);
            this.panel5.Controls.Add(this.AddAutobusBtn);
            this.panel5.Controls.Add(this.AutobusTB);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(5, 20);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(179, 466);
            this.panel5.TabIndex = 2;
            // 
            // Message
            // 
            this.Message.Controls.Add(this.panel1);
            this.Message.Location = new System.Drawing.Point(4, 25);
            this.Message.Name = "Message";
            this.Message.Padding = new System.Windows.Forms.Padding(3);
            this.Message.Size = new System.Drawing.Size(905, 486);
            this.Message.TabIndex = 0;
            this.Message.Text = "Сообщить";
            this.Message.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 5);
            this.panel1.Size = new System.Drawing.Size(899, 480);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SendBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 406);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(879, 69);
            this.panel2.TabIndex = 2;
            // 
            // SendBtn
            // 
            this.SendBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.SendBtn.Location = new System.Drawing.Point(702, 0);
            this.SendBtn.Name = "SendBtn";
            this.SendBtn.Size = new System.Drawing.Size(177, 69);
            this.SendBtn.TabIndex = 0;
            this.SendBtn.Text = "Разослать";
            this.SendBtn.UseVisualStyleBackColor = true;
            this.SendBtn.Click += new System.EventHandler(this.SendBtn_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 5);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.MessageTB);
            this.splitContainer1.Panel1.Controls.Add(this.panel4);
            this.splitContainer1.Panel1.Padding = new System.Windows.Forms.Padding(5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.AutobusLB);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(5);
            this.splitContainer1.Size = new System.Drawing.Size(879, 401);
            this.splitContainer1.SplitterDistance = 450;
            this.splitContainer1.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.RefreshBtn);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(415, 52);
            this.panel3.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список автобусов";
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RefreshBtn.Location = new System.Drawing.Point(281, 0);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(134, 52);
            this.RefreshBtn.TabIndex = 1;
            this.RefreshBtn.Text = "Обновить";
            this.RefreshBtn.UseVisualStyleBackColor = true;
            // 
            // AutobusLB
            // 
            this.AutobusLB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AutobusLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutobusLB.FormattingEnabled = true;
            this.AutobusLB.ItemHeight = 20;
            this.AutobusLB.Location = new System.Drawing.Point(5, 57);
            this.AutobusLB.Name = "AutobusLB";
            this.AutobusLB.Size = new System.Drawing.Size(415, 339);
            this.AutobusLB.TabIndex = 2;
            this.AutobusLB.SelectedIndexChanged += new System.EventHandler(this.AutobusLB_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 52);
            this.panel4.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Сообщение для пользователей";
            // 
            // MessageTB
            // 
            this.MessageTB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessageTB.Location = new System.Drawing.Point(5, 57);
            this.MessageTB.Multiline = true;
            this.MessageTB.Name = "MessageTB";
            this.MessageTB.Size = new System.Drawing.Size(440, 339);
            this.MessageTB.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Message);
            this.tabControl1.Controls.Add(this.ViewAutobus);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 515);
            this.tabControl1.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.AutobusDataGridView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(184, 20);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(716, 466);
            this.panel6.TabIndex = 3;
            // 
            // AutobusTB
            // 
            this.AutobusTB.Dock = System.Windows.Forms.DockStyle.Top;
            this.AutobusTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutobusTB.Location = new System.Drawing.Point(0, 0);
            this.AutobusTB.Name = "AutobusTB";
            this.AutobusTB.Size = new System.Drawing.Size(179, 26);
            this.AutobusTB.TabIndex = 3;
            // 
            // AddAutobusBtn
            // 
            this.AddAutobusBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddAutobusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddAutobusBtn.Location = new System.Drawing.Point(0, 26);
            this.AddAutobusBtn.Name = "AddAutobusBtn";
            this.AddAutobusBtn.Size = new System.Drawing.Size(179, 70);
            this.AddAutobusBtn.TabIndex = 4;
            this.AddAutobusBtn.Text = "Добавить";
            this.AddAutobusBtn.UseVisualStyleBackColor = true;
            this.AddAutobusBtn.Click += new System.EventHandler(this.AddAutobusBtn_Click);
            // 
            // DeleteAutobusBtn
            // 
            this.DeleteAutobusBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.DeleteAutobusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteAutobusBtn.Location = new System.Drawing.Point(0, 96);
            this.DeleteAutobusBtn.Name = "DeleteAutobusBtn";
            this.DeleteAutobusBtn.Size = new System.Drawing.Size(179, 70);
            this.DeleteAutobusBtn.TabIndex = 5;
            this.DeleteAutobusBtn.Text = "Удалить";
            this.DeleteAutobusBtn.UseVisualStyleBackColor = true;
            this.DeleteAutobusBtn.Click += new System.EventHandler(this.DeleteAutobusBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ViewAutobus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutobusDataGridView)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.Message.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage ViewAutobus;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView AutobusDataGridView;
        private System.Windows.Forms.TabPage Message;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AutobusLB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button AddAutobusBtn;
        private System.Windows.Forms.TextBox AutobusTB;
        private System.Windows.Forms.Button DeleteAutobusBtn;
    }
}