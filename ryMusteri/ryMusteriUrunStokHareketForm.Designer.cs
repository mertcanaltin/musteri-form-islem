﻿namespace ryMusteri
{
    partial class ryMusteriUrunStokHareketForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUrunListe = new System.Windows.Forms.DataGridView();
            this.btnAnaForm = new System.Windows.Forms.Button();
            this.tbUrunBilgisi = new System.Windows.Forms.TextBox();
            this.tbUrunKod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUrunListe
            // 
            this.dgvUrunListe.AllowUserToAddRows = false;
            this.dgvUrunListe.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUrunListe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUrunListe.ColumnHeadersHeight = 25;
            this.dgvUrunListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUrunListe.Location = new System.Drawing.Point(213, 9);
            this.dgvUrunListe.Name = "dgvUrunListe";
            this.dgvUrunListe.ReadOnly = true;
            this.dgvUrunListe.RowHeadersWidth = 25;
            this.dgvUrunListe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Navy;
            this.dgvUrunListe.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUrunListe.RowTemplate.Height = 25;
            this.dgvUrunListe.Size = new System.Drawing.Size(465, 217);
            this.dgvUrunListe.TabIndex = 23;
            // 
            // btnAnaForm
            // 
            this.btnAnaForm.BackgroundImage = global::ryMusteri.Properties.Resources.anaform;
            this.btnAnaForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAnaForm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnAnaForm.Location = new System.Drawing.Point(179, 198);
            this.btnAnaForm.Name = "btnAnaForm";
            this.btnAnaForm.Size = new System.Drawing.Size(28, 28);
            this.btnAnaForm.TabIndex = 22;
            this.btnAnaForm.UseVisualStyleBackColor = true;
            // 
            // tbUrunBilgisi
            // 
            this.tbUrunBilgisi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUrunBilgisi.Enabled = false;
            this.tbUrunBilgisi.Location = new System.Drawing.Point(11, 115);
            this.tbUrunBilgisi.MaxLength = 150;
            this.tbUrunBilgisi.Multiline = true;
            this.tbUrunBilgisi.Name = "tbUrunBilgisi";
            this.tbUrunBilgisi.Size = new System.Drawing.Size(196, 65);
            this.tbUrunBilgisi.TabIndex = 19;
            // 
            // tbUrunKod
            // 
            this.tbUrunKod.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbUrunKod.Enabled = false;
            this.tbUrunKod.Location = new System.Drawing.Point(115, 31);
            this.tbUrunKod.MaxLength = 8;
            this.tbUrunKod.Name = "tbUrunKod";
            this.tbUrunKod.Size = new System.Drawing.Size(91, 24);
            this.tbUrunKod.TabIndex = 18;
            this.tbUrunKod.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Location = new System.Drawing.Point(10, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 21;
            this.label2.Text = "Ürün Bilgisi :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(10, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 20;
            this.label1.Text = "Ürün Kodu :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ryMusteriUrunStokHareketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 238);
            this.ControlBox = false;
            this.Controls.Add(this.dgvUrunListe);
            this.Controls.Add(this.btnAnaForm);
            this.Controls.Add(this.tbUrunBilgisi);
            this.Controls.Add(this.tbUrunKod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ryMusteriUrunStokHareketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MBS - URUN STOK HAREKETLERİ";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUrunListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUrunListe;
        private System.Windows.Forms.Button btnAnaForm;
        public System.Windows.Forms.TextBox tbUrunBilgisi;
        public System.Windows.Forms.TextBox tbUrunKod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}