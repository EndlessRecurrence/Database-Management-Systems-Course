﻿
namespace Lab_1
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
            this.usersDataGridView = new System.Windows.Forms.DataGridView();
            this.onlineMusicStoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.onlineMusicStoreDataSet = new Lab_1.OnlineMusicStoreDataSet();
            this.transactionsDataGridView = new System.Windows.Forms.DataGridView();
            this.updateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMusicStoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMusicStoreDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDataGridView
            // 
            this.usersDataGridView.AutoGenerateColumns = false;
            this.usersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDataGridView.DataSource = this.onlineMusicStoreDataSetBindingSource;
            this.usersDataGridView.Location = new System.Drawing.Point(12, 12);
            this.usersDataGridView.Name = "usersDataGridView";
            this.usersDataGridView.RowHeadersWidth = 51;
            this.usersDataGridView.RowTemplate.Height = 24;
            this.usersDataGridView.Size = new System.Drawing.Size(563, 199);
            this.usersDataGridView.TabIndex = 0;
            // 
            // onlineMusicStoreDataSetBindingSource
            // 
            this.onlineMusicStoreDataSetBindingSource.DataSource = this.onlineMusicStoreDataSet;
            this.onlineMusicStoreDataSetBindingSource.Position = 0;
            // 
            // onlineMusicStoreDataSet
            // 
            this.onlineMusicStoreDataSet.DataSetName = "OnlineMusicStoreDataSet";
            this.onlineMusicStoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transactionsDataGridView
            // 
            this.transactionsDataGridView.AutoGenerateColumns = false;
            this.transactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsDataGridView.DataSource = this.onlineMusicStoreDataSetBindingSource;
            this.transactionsDataGridView.Location = new System.Drawing.Point(13, 244);
            this.transactionsDataGridView.Name = "transactionsDataGridView";
            this.transactionsDataGridView.RowHeadersWidth = 51;
            this.transactionsDataGridView.RowTemplate.Height = 24;
            this.transactionsDataGridView.Size = new System.Drawing.Size(562, 194);
            this.transactionsDataGridView.TabIndex = 1;
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(656, 217);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 2;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.transactionsDataGridView);
            this.Controls.Add(this.usersDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMusicStoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.onlineMusicStoreDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDataGridView;
        private System.Windows.Forms.BindingSource onlineMusicStoreDataSetBindingSource;
        private OnlineMusicStoreDataSet onlineMusicStoreDataSet;
        private System.Windows.Forms.DataGridView transactionsDataGridView;
        private System.Windows.Forms.Button updateButton;
    }
}

