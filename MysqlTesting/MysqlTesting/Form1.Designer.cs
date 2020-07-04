namespace MysqlTesting
{
    partial class formMYSQL
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.iblAuthor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(402, 134);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(750, 363);
            this.dataGridView1.TabIndex = 0;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(148, 129);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(224, 22);
            this.txtBookName.TabIndex = 2;
            this.txtBookName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBookName_MouseClick);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(148, 175);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(224, 22);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtAuthor_MouseClick);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(148, 225);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(224, 22);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtDescription_MouseClick);
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(23, 134);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(81, 17);
            this.lblBookName.TabIndex = 7;
            this.lblBookName.Text = "Book Name";
            // 
            // iblAuthor
            // 
            this.iblAuthor.AutoSize = true;
            this.iblAuthor.Location = new System.Drawing.Point(23, 178);
            this.iblAuthor.Name = "iblAuthor";
            this.iblAuthor.Size = new System.Drawing.Size(50, 17);
            this.iblAuthor.TabIndex = 8;
            this.iblAuthor.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(26, 292);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 36);
            this.button2.TabIndex = 11;
            this.button2.Text = "Delete";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 292);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 36);
            this.button3.TabIndex = 12;
            this.button3.Text = "Cancel";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(711, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(836, 39);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(224, 22);
            this.txtsearch.TabIndex = 13;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // txtBookID
            // 
            this.txtBookID.Location = new System.Drawing.Point(148, 75);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(224, 22);
            this.txtBookID.TabIndex = 1;
            this.txtBookID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtBookID_MouseClick);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(23, 75);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(57, 17);
            this.lblBookID.TabIndex = 6;
            this.lblBookID.Text = "Book ID";
            // 
            // formMYSQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 522);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.iblAuthor);
            this.Controls.Add(this.lblBookName);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.txtBookName);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "formMYSQL";
            this.Text = "Basic CRUD in MySQL & C#";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label iblAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookID;
    }
}

