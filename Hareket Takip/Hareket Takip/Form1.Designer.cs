﻿namespace Hareket_Takip
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.hareketTakipDataSet1 = new Hareket_Takip.HareketTakipDataSet1();
            this.hareketTakipBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hareketTakipTableAdapter = new Hareket_Takip.HareketTakipDataSet1TableAdapters.HareketTakipTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.hareketTakipDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketTakipBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // hareketTakipDataSet1
            // 
            this.hareketTakipDataSet1.DataSetName = "HareketTakipDataSet1";
            this.hareketTakipDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hareketTakipBindingSource
            // 
            this.hareketTakipBindingSource.DataMember = "HareketTakip";
            this.hareketTakipBindingSource.DataSource = this.hareketTakipDataSet1;
            // 
            // hareketTakipTableAdapter
            // 
            this.hareketTakipTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(539, 332);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 332);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hareketTakipDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hareketTakipBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private HareketTakipDataSet1 hareketTakipDataSet1;
        private System.Windows.Forms.BindingSource hareketTakipBindingSource;
        private HareketTakipDataSet1TableAdapters.HareketTakipTableAdapter hareketTakipTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

