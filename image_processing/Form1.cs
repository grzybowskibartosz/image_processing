namespace image_processing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void load_image_button_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }

        private void filter_image_button_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                Bitmap originalImage = new Bitmap(pictureBox1.Image);
                Bitmap copy = new Bitmap(originalImage);
                Bitmap copy1 = new Bitmap(originalImage);
                Bitmap copy2 = new Bitmap(originalImage);
                Bitmap copy3 = new Bitmap(originalImage);

                Task thresholdingTask = Task.Run(() =>
                {
                    pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox2.Image = ApplyThresholding(copy, 128);
                });

                Task negativeTask = Task.Run(() =>
                {
                    pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox3.Image = ApplyNegative(copy1);
                });

                Task grayscaleTask = Task.Run(() =>
                {
                    pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox4.Image = ApplyGrayscale(copy2);
                });

                Task mirrorTask = Task.Run(() =>
                {
                    pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
                    pictureBox5.Image = ApplyMirror(copy3);
                });

                Task.WaitAll(thresholdingTask, negativeTask, grayscaleTask, mirrorTask);
            }
        }


        private Bitmap ApplyThresholding(Bitmap image, int threshold)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int i=0; i<image.Height; i++) 
            {
                for (int j=0; j<image.Width; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    int grayscale = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                    if (grayscale < threshold)
                    {
                        newImage.SetPixel(i, j, Color.Black);
                    }
                    else
                    {
                        newImage.SetPixel(i, j, Color.White);
                    }
                }
            }

            return newImage;
        }

        private Bitmap ApplyNegative(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int i=0; i<newImage.Height; i++)
            {
                for (int j=0; j<newImage.Width; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    Color negativeColor = Color.FromArgb(255 - pixel.R, 255 - pixel.G, 255 - pixel.B);
                    newImage.SetPixel(i, j, negativeColor);
                }
            }
            return newImage;
        }

        private Bitmap ApplyGrayscale(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int i=0; i<newImage.Height; i++)
            {
                for (int j=0; j<newImage.Width; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    int grayscale = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                    Color grayscaleColor = Color.FromArgb(grayscale, grayscale, grayscale);
                    newImage.SetPixel(i, j, grayscaleColor);
                }
            }

            return newImage;
        }

        private Bitmap ApplyMirror(Bitmap image)
        {
            Bitmap newImage = new Bitmap(image.Width, image.Height);

            for (int i=0; i<newImage.Height; i++)
            {
                for (int j=0; j<newImage.Width; j++)
                {
                    Color pixel = image.GetPixel(i, j);
                    newImage.SetPixel(newImage.Width - 1 - i, j, pixel);
                }
            }

            return newImage;
        }
    }
}
