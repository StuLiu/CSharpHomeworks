namespace DrawTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.draw_btn = new System.Windows.Forms.Button();
            this.left_bar = new System.Windows.Forms.TrackBar();
            this.right_bar = new System.Windows.Forms.TrackBar();
            this.left_lable = new System.Windows.Forms.Label();
            this.right_lable = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.left_bar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_bar)).BeginInit();
            this.SuspendLayout();
            // 
            // draw_btn
            // 
            this.draw_btn.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.draw_btn.Location = new System.Drawing.Point(326, 460);
            this.draw_btn.Name = "draw_btn";
            this.draw_btn.Size = new System.Drawing.Size(89, 28);
            this.draw_btn.TabIndex = 0;
            this.draw_btn.Text = "Draw";
            this.draw_btn.UseVisualStyleBackColor = true;
            this.draw_btn.Click += new System.EventHandler(this.draw_btn_Click);
            // 
            // left_bar
            // 
            this.left_bar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.left_bar.Location = new System.Drawing.Point(33, 165);
            this.left_bar.Maximum = 100;
            this.left_bar.Minimum = 70;
            this.left_bar.Name = "left_bar";
            this.left_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.left_bar.Size = new System.Drawing.Size(45, 178);
            this.left_bar.TabIndex = 1;
            this.left_bar.Value = 70;
            // 
            // right_bar
            // 
            this.right_bar.Location = new System.Drawing.Point(650, 165);
            this.right_bar.Maximum = 100;
            this.right_bar.Minimum = 70;
            this.right_bar.Name = "right_bar";
            this.right_bar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.right_bar.Size = new System.Drawing.Size(45, 178);
            this.right_bar.TabIndex = 2;
            this.right_bar.Value = 70;
            // 
            // left_lable
            // 
            this.left_lable.AutoSize = true;
            this.left_lable.Location = new System.Drawing.Point(19, 346);
            this.left_lable.Name = "left_lable";
            this.left_lable.Size = new System.Drawing.Size(59, 12);
            this.left_lable.TabIndex = 3;
            this.left_lable.Text = "leftRatio";
            // 
            // right_lable
            // 
            this.right_lable.AutoSize = true;
            this.right_lable.Location = new System.Drawing.Point(630, 346);
            this.right_lable.Name = "right_lable";
            this.right_lable.Size = new System.Drawing.Size(65, 12);
            this.right_lable.TabIndex = 4;
            this.right_lable.Text = "rightRatio";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 500);
            this.Controls.Add(this.right_lable);
            this.Controls.Add(this.left_lable);
            this.Controls.Add(this.right_bar);
            this.Controls.Add(this.left_bar);
            this.Controls.Add(this.draw_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.left_bar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.right_bar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button draw_btn;
        private System.Windows.Forms.TrackBar left_bar;
        private System.Windows.Forms.TrackBar right_bar;
        private System.Windows.Forms.Label left_lable;
        private System.Windows.Forms.Label right_lable;
    }
}

