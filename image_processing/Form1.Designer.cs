namespace image_processing
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
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            load_image_button = new Button();
            filter_image_button = new Button();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 41);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(365, 365);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // load_image_button
            // 
            load_image_button.Location = new Point(145, 12);
            load_image_button.Name = "load_image_button";
            load_image_button.Size = new Size(96, 23);
            load_image_button.TabIndex = 1;
            load_image_button.Text = "Wczytaj obraz";
            load_image_button.UseVisualStyleBackColor = true;
            load_image_button.Click += load_image_button_Click;
            // 
            // filter_image_button
            // 
            filter_image_button.Location = new Point(552, 12);
            filter_image_button.Name = "filter_image_button";
            filter_image_button.Size = new Size(96, 23);
            filter_image_button.TabIndex = 2;
            filter_image_button.Text = "Zastosuj filtry";
            filter_image_button.UseVisualStyleBackColor = true;
            filter_image_button.Click += filter_image_button_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(406, 41);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(184, 183);
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(596, 41);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(171, 183);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(406, 230);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(184, 176);
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(596, 230);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(171, 176);
            pictureBox5.TabIndex = 6;
            pictureBox5.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(filter_image_button);
            Controls.Add(load_image_button);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
        private Button load_image_button;
        private Button filter_image_button;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
    }
}
