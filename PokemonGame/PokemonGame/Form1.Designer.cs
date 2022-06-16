
namespace PokemonGame
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
            this.Main_panel1 = new System.Windows.Forms.Panel();
            this.Ash_pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Ash_Movement_timer1 = new System.Windows.Forms.Timer(this.components);
            this.Main_panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ash_pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Main_panel1
            // 
            this.Main_panel1.BackColor = System.Drawing.Color.Honeydew;
            this.Main_panel1.Controls.Add(this.Ash_pictureBox1);
            this.Main_panel1.Location = new System.Drawing.Point(8, 12);
            this.Main_panel1.Name = "Main_panel1";
            this.Main_panel1.Size = new System.Drawing.Size(789, 777);
            this.Main_panel1.TabIndex = 0;
            // 
            // Ash_pictureBox1
            // 
            this.Ash_pictureBox1.BackgroundImage = global::PokemonGame.Properties.Resources.Ash_Front_1;
            this.Ash_pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ash_pictureBox1.Location = new System.Drawing.Point(240, 240);
            this.Ash_pictureBox1.Name = "Ash_pictureBox1";
            this.Ash_pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.Ash_pictureBox1.TabIndex = 0;
            this.Ash_pictureBox1.TabStop = false;
            // 
            // Ash_Movement_timer1
            // 
            this.Ash_Movement_timer1.Interval = 200;
            this.Ash_Movement_timer1.Tick += new System.EventHandler(this.Ash_Movement_timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 792);
            this.Controls.Add(this.Main_panel1);
            this.Name = "Form1";
            this.Text = "Pokemon";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.Main_panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Ash_pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main_panel1;
        private System.Windows.Forms.PictureBox Ash_pictureBox1;
        private System.Windows.Forms.Timer Ash_Movement_timer1;
    }
}

