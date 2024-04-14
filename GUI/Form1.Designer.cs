namespace GUI
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
            components = new System.ComponentModel.Container();
            addCatFactBtn = new Button();
            addCatFactInput = new TextBox();
            showDataBtn = new Button();
            keyWordInput = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            maxLenghtInput = new NumericUpDown();
            viewBox = new ListBox();
            DeleteBtn = new Button();
            GetDataFromApiBtn = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)maxLenghtInput).BeginInit();
            SuspendLayout();
            // 
            // addCatFactBtn
            // 
            addCatFactBtn.Location = new Point(12, 47);
            addCatFactBtn.Name = "addCatFactBtn";
            addCatFactBtn.Size = new Size(134, 29);
            addCatFactBtn.TabIndex = 0;
            addCatFactBtn.Text = "Add Cat Fact";
            addCatFactBtn.UseVisualStyleBackColor = true;
            addCatFactBtn.Click += addCatFactBtn_Click;
            // 
            // addCatFactInput
            // 
            addCatFactInput.Location = new Point(12, 82);
            addCatFactInput.Name = "addCatFactInput";
            addCatFactInput.Size = new Size(371, 27);
            addCatFactInput.TabIndex = 3;
            // 
            // showDataBtn
            // 
            showDataBtn.Location = new Point(389, 317);
            showDataBtn.Name = "showDataBtn";
            showDataBtn.Size = new Size(93, 29);
            showDataBtn.TabIndex = 4;
            showDataBtn.Text = "Show Data";
            showDataBtn.UseVisualStyleBackColor = true;
            showDataBtn.Click += showDataBtn_Click;
            // 
            // keyWordInput
            // 
            keyWordInput.Location = new Point(12, 283);
            keyWordInput.Name = "keyWordInput";
            keyWordInput.Size = new Size(134, 27);
            keyWordInput.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 229);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 6;
            label1.Text = "Filters:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 260);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 7;
            label2.Text = "Key Word:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 260);
            label3.Name = "label3";
            label3.Size = new Size(86, 20);
            label3.TabIndex = 8;
            label3.Text = "Max Length";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // maxLenghtInput
            // 
            maxLenghtInput.Location = new Point(175, 284);
            maxLenghtInput.Name = "maxLenghtInput";
            maxLenghtInput.Size = new Size(150, 27);
            maxLenghtInput.TabIndex = 11;
            // 
            // viewBox
            // 
            viewBox.FormattingEnabled = true;
            viewBox.Location = new Point(389, 47);
            viewBox.Name = "viewBox";
            viewBox.Size = new Size(973, 264);
            viewBox.TabIndex = 12;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Location = new Point(488, 317);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(93, 29);
            DeleteBtn.TabIndex = 13;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += deleteBtn_Click;
            // 
            // GetDataFromApiBtn
            // 
            GetDataFromApiBtn.Location = new Point(587, 317);
            GetDataFromApiBtn.Name = "GetDataFromApiBtn";
            GetDataFromApiBtn.Size = new Size(151, 29);
            GetDataFromApiBtn.TabIndex = 14;
            GetDataFromApiBtn.Text = "Get Data From Api";
            GetDataFromApiBtn.UseVisualStyleBackColor = true;
            GetDataFromApiBtn.Click += getDataFromApiBtn_Click;
            // 
            // button1
            // 
            button1.Location = new Point(744, 317);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 15;
            button1.Text = "Clear Filters";
            button1.UseVisualStyleBackColor = true;
            button1.Click += clearFiltersBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1374, 486);
            Controls.Add(button1);
            Controls.Add(GetDataFromApiBtn);
            Controls.Add(DeleteBtn);
            Controls.Add(viewBox);
            Controls.Add(maxLenghtInput);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(keyWordInput);
            Controls.Add(showDataBtn);
            Controls.Add(addCatFactInput);
            Controls.Add(addCatFactBtn);
            Name = "Form1";
            Text = "Get Data From Api";
            ((System.ComponentModel.ISupportInitialize)maxLenghtInput).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addCatFactBtn;
        private Button DeleteBtn;
        private Button showDataBtn;
        private TextBox addCatFactInput;
        private TextBox keyWordInput;
        private NumericUpDown maxLenghtInput;
        private ListBox viewBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private ContextMenuStrip contextMenuStrip1;
        private Button GetDataFromApiBtn;
        private Button button1;
    }
}
