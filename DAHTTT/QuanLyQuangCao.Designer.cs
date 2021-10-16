
namespace DAHTTT
{
    partial class QuanLyQuangCao
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.AdsID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AdsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Place = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ViewInfo = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteAds = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quản lý Quảng Cáo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(663, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Thêm Quảng Cáo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AdsID,
            this.AdsName,
            this.Place,
            this.Duration,
            this.ViewInfo,
            this.DeleteAds});
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 261);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Danh sách Quảng cáo:";
            // 
            // AdsID
            // 
            this.AdsID.HeaderText = "ID";
            this.AdsID.MinimumWidth = 6;
            this.AdsID.Name = "AdsID";
            this.AdsID.Width = 60;
            // 
            // AdsName
            // 
            this.AdsName.HeaderText = "Tên QC";
            this.AdsName.MinimumWidth = 6;
            this.AdsName.Name = "AdsName";
            this.AdsName.Width = 125;
            // 
            // Place
            // 
            this.Place.HeaderText = "Vị trí";
            this.Place.MinimumWidth = 6;
            this.Place.Name = "Place";
            this.Place.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Thời hạn";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 200;
            // 
            // ViewInfo
            // 
            this.ViewInfo.HeaderText = "Xem";
            this.ViewInfo.MinimumWidth = 6;
            this.ViewInfo.Name = "ViewInfo";
            this.ViewInfo.Width = 60;
            // 
            // DeleteAds
            // 
            this.DeleteAds.HeaderText = "Xoá";
            this.DeleteAds.MinimumWidth = 6;
            this.DeleteAds.Name = "DeleteAds";
            this.DeleteAds.Width = 60;
            // 
            // QuanLyQuangCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 344);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyQuangCao";
            this.Text = "QuanLyQuangCao";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdsID;
        private System.Windows.Forms.DataGridViewTextBoxColumn AdsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Place;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewButtonColumn ViewInfo;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteAds;
    }
}