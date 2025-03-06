namespace SqlForm.Forms
{
    partial class QueryForm
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
            queryBox = new TextBox();
            panel1 = new Panel();
            updateQueryButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // queryBox
            // 
            queryBox.Dock = DockStyle.Fill;
            queryBox.Font = new Font("MS Reference Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            queryBox.Location = new Point(0, 0);
            queryBox.Multiline = true;
            queryBox.Name = "queryBox";
            queryBox.Size = new Size(776, 397);
            queryBox.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(updateQueryButton);
            panel1.Controls.Add(queryBox);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 397);
            panel1.TabIndex = 1;
            // 
            // updateQueryButton
            // 
            updateQueryButton.Font = new Font("MS Reference Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            updateQueryButton.Location = new Point(323, 362);
            updateQueryButton.Name = "updateQueryButton";
            updateQueryButton.Size = new Size(120, 32);
            updateQueryButton.TabIndex = 1;
            updateQueryButton.Text = "Update Query";
            updateQueryButton.UseVisualStyleBackColor = true;
            updateQueryButton.Click += UpdateQueryButton_Click;
            // 
            // QueryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 421);
            Controls.Add(panel1);
            Name = "QueryForm";
            Text = "Query";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox queryBox;
        private Panel panel1;
        private Button updateQueryButton;
    }
}