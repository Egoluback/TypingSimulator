namespace TypingSimulator
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userTextLabel = new System.Windows.Forms.Label();
            this.correctTextLabel = new System.Windows.Forms.Label();
            this.labelHelp1 = new System.Windows.Forms.Label();
            this.labelError = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelKey = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // userTextLabel
            // 
            this.userTextLabel.AutoSize = true;
            this.userTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userTextLabel.Location = new System.Drawing.Point(10, 16);
            this.userTextLabel.MaximumSize = new System.Drawing.Size(770, 230);
            this.userTextLabel.Name = "userTextLabel";
            this.userTextLabel.Size = new System.Drawing.Size(0, 26);
            this.userTextLabel.TabIndex = 0;
            // 
            // correctTextLabel
            // 
            this.correctTextLabel.AutoSize = true;
            this.correctTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.correctTextLabel.Location = new System.Drawing.Point(6, 16);
            this.correctTextLabel.MaximumSize = new System.Drawing.Size(405, 250);
            this.correctTextLabel.Name = "correctTextLabel";
            this.correctTextLabel.Size = new System.Drawing.Size(68, 26);
            this.correctTextLabel.TabIndex = 1;
            this.correctTextLabel.Text = "Текст";
            // 
            // labelHelp1
            // 
            this.labelHelp1.AutoSize = true;
            this.labelHelp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHelp1.Location = new System.Drawing.Point(0, 25);
            this.labelHelp1.Name = "labelHelp1";
            this.labelHelp1.Size = new System.Drawing.Size(177, 26);
            this.labelHelp1.TabIndex = 2;
            this.labelHelp1.Text = "Наберите текст:";
            // 
            // labelError
            // 
            this.labelError.AutoSize = true;
            this.labelError.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelError.ForeColor = System.Drawing.Color.SlateGray;
            this.labelError.Location = new System.Drawing.Point(635, 25);
            this.labelError.MaximumSize = new System.Drawing.Size(140, 100);
            this.labelError.Name = "labelError";
            this.labelError.Size = new System.Drawing.Size(138, 26);
            this.labelError.TabIndex = 3;
            this.labelError.Text = "Печатайте...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.correctTextLabel);
            this.groupBox1.Location = new System.Drawing.Point(177, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 228);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.userTextLabel);
            this.groupBox2.Location = new System.Drawing.Point(12, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 195);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // labelKey
            // 
            this.labelKey.AutoSize = true;
            this.labelKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelKey.Location = new System.Drawing.Point(635, 86);
            this.labelKey.MaximumSize = new System.Drawing.Size(200, 200);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(0, 26);
            this.labelKey.TabIndex = 6;
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(12, 75);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 26);
            this.labelTime.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelKey);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelError);
            this.Controls.Add(this.labelHelp1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainForm";
            this.Text = "Typing simulator";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form_KeyPress);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label userTextLabel;
        private System.Windows.Forms.Label correctTextLabel;
        private System.Windows.Forms.Label labelHelp1;
        private System.Windows.Forms.Label labelError;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelKey;
        private System.Windows.Forms.Label labelTime;
    }
}

