﻿namespace ChuckForm
{
    partial class ChuckNorrisJokeGenerator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChuckNorrisJokeGenerator));
            this.GetMeTheJoke = new System.Windows.Forms.Button();
            this.JokeBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // GetMeTheJoke
            // 
            this.GetMeTheJoke.Location = new System.Drawing.Point(403, 45);
            this.GetMeTheJoke.Name = "GetMeTheJoke";
            this.GetMeTheJoke.Size = new System.Drawing.Size(75, 23);
            this.GetMeTheJoke.TabIndex = 0;
            this.GetMeTheJoke.Text = "GetJoke";
            this.GetMeTheJoke.UseVisualStyleBackColor = true;
            this.GetMeTheJoke.Click += new System.EventHandler(this.button1_Click);
            // 
            // JokeBox
            // 
            this.JokeBox.Location = new System.Drawing.Point(378, 74);
            this.JokeBox.Name = "JokeBox";
            this.JokeBox.Size = new System.Drawing.Size(231, 276);
            this.JokeBox.TabIndex = 1;
            this.JokeBox.Text = "Get the Joke, I Dare You";
            // 
            // ChuckNorrisJokeGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(621, 414);
            this.Controls.Add(this.JokeBox);
            this.Controls.Add(this.GetMeTheJoke);
            this.Name = "ChuckNorrisJokeGenerator";
            this.Text = "ChuckNorrisJokeGenerator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button GetMeTheJoke;
        private System.Windows.Forms.RichTextBox JokeBox;
    }
}

