namespace WinFormsMultTable_JL
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
            MainPanel = new Panel();
            richtextboxRes = new RichTextBox();
            buttonTable = new Button();
            textBoxNum = new TextBox();
            labelnum = new Label();
            LabelTitulo = new Label();
            label1 = new Label();
            label2 = new Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.ButtonShadow;
            MainPanel.BorderStyle = BorderStyle.Fixed3D;
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(richtextboxRes);
            MainPanel.Controls.Add(buttonTable);
            MainPanel.Controls.Add(textBoxNum);
            MainPanel.Controls.Add(labelnum);
            MainPanel.Controls.Add(LabelTitulo);
            MainPanel.Location = new Point(12, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(776, 426);
            MainPanel.TabIndex = 0;
            // 
            // richtextboxRes
            // 
            richtextboxRes.Font = new Font("SimSun-ExtB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            richtextboxRes.Location = new Point(378, 29);
            richtextboxRes.Name = "richtextboxRes";
            richtextboxRes.Size = new Size(379, 376);
            richtextboxRes.TabIndex = 4;
            richtextboxRes.Text = "";
            richtextboxRes.TextChanged += richtextboxRes_TextChanged;
            // 
            // buttonTable
            // 
            buttonTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonTable.Location = new Point(92, 302);
            buttonTable.Name = "buttonTable";
            buttonTable.Size = new Size(174, 66);
            buttonTable.TabIndex = 3;
            buttonTable.Text = "Generar Tabla";
            buttonTable.UseVisualStyleBackColor = true;
            buttonTable.Click += buttonTable_Click;
            // 
            // textBoxNum
            // 
            textBoxNum.Location = new Point(78, 120);
            textBoxNum.Name = "textBoxNum";
            textBoxNum.Size = new Size(188, 27);
            textBoxNum.TabIndex = 2;
            // 
            // labelnum
            // 
            labelnum.AutoSize = true;
            labelnum.Location = new Point(67, 83);
            labelnum.Name = "labelnum";
            labelnum.Size = new Size(220, 20);
            labelnum.TabIndex = 1;
            labelnum.Text = "Numero para generar la tabla?: ";
            labelnum.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // LabelTitulo
            // 
            LabelTitulo.AutoSize = true;
            LabelTitulo.Font = new Font("Algerian", 16.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            LabelTitulo.Location = new Point(19, 29);
            LabelTitulo.Name = "LabelTitulo";
            LabelTitulo.Size = new Size(326, 31);
            LabelTitulo.TabIndex = 0;
            LabelTitulo.Text = "TABLA DE MULTIPLICAR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 175);
            label1.Name = "label1";
            label1.Size = new Size(146, 20);
            label1.TabIndex = 5;
            label1.Text = "Form elaborado por:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(78, 195);
            label2.Name = "label2";
            label2.Size = new Size(186, 20);
            label2.TabIndex = 6;
            label2.Text = "Jose Luis Narvaez Martinez";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            Name = "Form1";
            Text = "Form1";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private TextBox textBoxNum;
        private Label labelnum;
        private Label LabelTitulo;
        private RichTextBox richtextboxRes;
        private Button buttonTable;
        private Label label1;
        private Label label2;
    }
}
