namespace CallCenterApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label label1, label2, label3, label4;
        private System.Windows.Forms.TextBox txtTotalCalls, txtFirstCallResolved, txtEscalated, txtResponseTimes;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblAvgResult, lblFCRResult, lblEscResult;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblTitle;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalCalls = new System.Windows.Forms.TextBox();
            this.txtFirstCallResolved = new System.Windows.Forms.TextBox();
            this.txtEscalated = new System.Windows.Forms.TextBox();
            this.txtResponseTimes = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblAvgResult = new System.Windows.Forms.Label();
            this.lblFCRResult = new System.Windows.Forms.Label();
            this.lblEscResult = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label1.Location = new System.Drawing.Point(30, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Общее число звонков:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label2.Location = new System.Drawing.Point(30, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Решено с первого звонка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label3.Location = new System.Drawing.Point(30, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(288, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Переведено на 2-го оператора:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.label4.Location = new System.Drawing.Point(30, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Время ответа (сек):";
            // 
            // txtTotalCalls
            // 
            this.txtTotalCalls.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtTotalCalls.Location = new System.Drawing.Point(481, 110);
            this.txtTotalCalls.Name = "txtTotalCalls";
            this.txtTotalCalls.Size = new System.Drawing.Size(200, 32);
            this.txtTotalCalls.TabIndex = 2;
            this.txtTotalCalls.Text = "100";
            // 
            // txtFirstCallResolved
            // 
            this.txtFirstCallResolved.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtFirstCallResolved.Location = new System.Drawing.Point(481, 155);
            this.txtFirstCallResolved.Name = "txtFirstCallResolved";
            this.txtFirstCallResolved.Size = new System.Drawing.Size(200, 32);
            this.txtFirstCallResolved.TabIndex = 4;
            this.txtFirstCallResolved.Text = "75";
            // 
            // txtEscalated
            // 
            this.txtEscalated.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtEscalated.Location = new System.Drawing.Point(481, 200);
            this.txtEscalated.Name = "txtEscalated";
            this.txtEscalated.Size = new System.Drawing.Size(200, 32);
            this.txtEscalated.TabIndex = 6;
            this.txtEscalated.Text = "15";
            // 
            // txtResponseTimes
            // 
            this.txtResponseTimes.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.txtResponseTimes.Location = new System.Drawing.Point(481, 245);
            this.txtResponseTimes.Name = "txtResponseTimes";
            this.txtResponseTimes.Size = new System.Drawing.Size(200, 32);
            this.txtResponseTimes.TabIndex = 8;
            this.txtResponseTimes.Text = "12 8 15 10 20 18 22";
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCalculate.ForeColor = System.Drawing.Color.White;
            this.btnCalculate.Location = new System.Drawing.Point(35, 287);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(200, 45);
            this.btnCalculate.TabIndex = 9;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblAvgResult
            // 
            this.lblAvgResult.AutoSize = true;
            this.lblAvgResult.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblAvgResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lblAvgResult.Location = new System.Drawing.Point(30, 360);
            this.lblAvgResult.Name = "lblAvgResult";
            this.lblAvgResult.Size = new System.Drawing.Size(0, 30);
            this.lblAvgResult.TabIndex = 10;
            // 
            // lblFCRResult
            // 
            this.lblFCRResult.AutoSize = true;
            this.lblFCRResult.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblFCRResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.lblFCRResult.Location = new System.Drawing.Point(30, 400);
            this.lblFCRResult.Name = "lblFCRResult";
            this.lblFCRResult.Size = new System.Drawing.Size(0, 30);
            this.lblFCRResult.TabIndex = 11;
            // 
            // lblEscResult
            // 
            this.lblEscResult.AutoSize = true;
            this.lblEscResult.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.lblEscResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(57)))), ((int)(((byte)(43)))));
            this.lblEscResult.Location = new System.Drawing.Point(30, 440);
            this.lblEscResult.Name = "lblEscResult";
            this.lblEscResult.Size = new System.Drawing.Size(0, 30);
            this.lblEscResult.TabIndex = 12;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panelHeader.Controls.Add(this.lblTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(739, 80);
            this.panelHeader.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(137, 18);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(485, 41);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "📞 Анализ работы колл-центра";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(739, 500);
            this.Controls.Add(this.lblEscResult);
            this.Controls.Add(this.lblFCRResult);
            this.Controls.Add(this.lblAvgResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtResponseTimes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEscalated);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFirstCallResolved);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTotalCalls);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Анализ колл-центра";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}