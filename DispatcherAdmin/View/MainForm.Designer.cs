
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Message = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SendBtn = new System.Windows.Forms.Button();
            this.ViewClients = new System.Windows.Forms.TabPage();
            this.ClientDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewAutobus = new System.Windows.Forms.TabPage();
            this.AutobusDataGridView = new System.Windows.Forms.DataGridView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.AutobusLB = new System.Windows.Forms.ListBox();
            this.MessageTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RefreshBtn = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.Message.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.ViewClients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).BeginInit();
            this.ViewAutobus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AutobusDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Message);
            this.tabControl1.Controls.Add(this.ViewClients);
            this.tabControl1.Controls.Add(this.ViewAutobus);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(913, 515);
            this.tabControl1.TabIndex = 0;
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
            // 
            // ViewClients
            // 
            this.ViewClients.Controls.Add(this.ClientDataGridView);
            this.ViewClients.Location = new System.Drawing.Point(4, 25);
            this.ViewClients.Name = "ViewClients";
            this.ViewClients.Padding = new System.Windows.Forms.Padding(3);
            this.ViewClients.Size = new System.Drawing.Size(905, 486);
            this.ViewClients.TabIndex = 1;
            this.ViewClients.Text = "Посмотреть пользователей";
            this.ViewClients.UseVisualStyleBackColor = true;
            // 
            // ClientDataGridView
            // 
            this.ClientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientDataGridView.Location = new System.Drawing.Point(103, 43);
            this.ClientDataGridView.Name = "ClientDataGridView";
            this.ClientDataGridView.Size = new System.Drawing.Size(556, 280);
            this.ClientDataGridView.TabIndex = 0;
            // 
            // ViewAutobus
            // 
            this.ViewAutobus.Controls.Add(this.AutobusDataGridView);
            this.ViewAutobus.Location = new System.Drawing.Point(4, 25);
            this.ViewAutobus.Name = "ViewAutobus";
            this.ViewAutobus.Size = new System.Drawing.Size(905, 486);
            this.ViewAutobus.TabIndex = 2;
            this.ViewAutobus.Text = "Посмотреть автобусы";
            this.ViewAutobus.UseVisualStyleBackColor = true;
            // 
            // AutobusDataGridView
            // 
            this.AutobusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AutobusDataGridView.Location = new System.Drawing.Point(128, 76);
            this.AutobusDataGridView.Name = "AutobusDataGridView";
            this.AutobusDataGridView.Size = new System.Drawing.Size(556, 280);
            this.AutobusDataGridView.TabIndex = 1;
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
            // panel4
            // 
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(440, 52);
            this.panel4.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Список автобусов";
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 515);
            this.Controls.Add(this.tabControl1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.tabControl1.ResumeLayout(false);
            this.Message.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ViewClients.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientDataGridView)).EndInit();
            this.ViewAutobus.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AutobusDataGridView)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Message;
        private System.Windows.Forms.TabPage ViewClients;
        private System.Windows.Forms.TabPage ViewAutobus;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SendBtn;
        private System.Windows.Forms.DataGridView ClientDataGridView;
        private System.Windows.Forms.DataGridView AutobusDataGridView;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TextBox MessageTB;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox AutobusLB;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button RefreshBtn;
        private System.Windows.Forms.Label label1;
    }
}