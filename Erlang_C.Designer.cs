namespace Erlang_Calculator
{
    partial class Erlang_C
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
            this.period_combo_bx = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.shrinkage_bx = new System.Windows.Forms.TextBox();
            this.clear_btn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.req_sla_bx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AHT_s_bx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.calculate_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.num_calls_bx = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.add_agents = new System.Windows.Forms.TextBox();
            this.w_shrinkage = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.asa_bx = new System.Windows.Forms.TextBox();
            this.raw_agents = new System.Windows.Forms.TextBox();
            this.max_occ = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.calls_ans = new System.Windows.Forms.TextBox();
            this.prob_wait = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.sla_bx = new System.Windows.Forms.TextBox();
            this.traffic_intesity = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.TAT_combo_bx = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // period_combo_bx
            // 
            this.period_combo_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.period_combo_bx.FormattingEnabled = true;
            this.period_combo_bx.Items.AddRange(new object[] {
            "15",
            "30",
            "60"});
            this.period_combo_bx.Location = new System.Drawing.Point(19, 122);
            this.period_combo_bx.MaxLength = 3;
            this.period_combo_bx.Name = "period_combo_bx";
            this.period_combo_bx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.period_combo_bx.Size = new System.Drawing.Size(81, 21);
            this.period_combo_bx.TabIndex = 106;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(19, 188);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(72, 13);
            this.label11.TabIndex = 102;
            this.label11.Text = "Shrinkage (%)";
            // 
            // shrinkage_bx
            // 
            this.shrinkage_bx.Location = new System.Drawing.Point(19, 204);
            this.shrinkage_bx.Name = "shrinkage_bx";
            this.shrinkage_bx.Size = new System.Drawing.Size(81, 20);
            this.shrinkage_bx.TabIndex = 101;
            this.shrinkage_bx.Text = "90%";
            this.shrinkage_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.SystemColors.Control;
            this.clear_btn.Location = new System.Drawing.Point(359, 335);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(133, 33);
            this.clear_btn.TabIndex = 99;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(19, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 13);
            this.label7.TabIndex = 98;
            this.label7.Text = "Target Answer Time (Seconds)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(19, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 97;
            this.label6.Text = "Required SLA (%)";
            // 
            // req_sla_bx
            // 
            this.req_sla_bx.Location = new System.Drawing.Point(19, 284);
            this.req_sla_bx.Name = "req_sla_bx";
            this.req_sla_bx.Size = new System.Drawing.Size(81, 20);
            this.req_sla_bx.TabIndex = 96;
            this.req_sla_bx.Text = "90%";
            this.req_sla_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(19, 229);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 13);
            this.label4.TabIndex = 95;
            this.label4.Text = "Average Handling Time (Seconds)";
            // 
            // AHT_s_bx
            // 
            this.AHT_s_bx.Location = new System.Drawing.Point(19, 244);
            this.AHT_s_bx.Name = "AHT_s_bx";
            this.AHT_s_bx.Size = new System.Drawing.Size(81, 20);
            this.AHT_s_bx.TabIndex = 94;
            this.AHT_s_bx.Text = "260";
            this.AHT_s_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(19, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "Period In Minutes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 92;
            this.label1.Text = "Parameters";
            // 
            // calculate_btn
            // 
            this.calculate_btn.BackColor = System.Drawing.SystemColors.Control;
            this.calculate_btn.Location = new System.Drawing.Point(210, 335);
            this.calculate_btn.Name = "calculate_btn";
            this.calculate_btn.Size = new System.Drawing.Size(133, 33);
            this.calculate_btn.TabIndex = 91;
            this.calculate_btn.Text = "Calculate";
            this.calculate_btn.UseVisualStyleBackColor = false;
            this.calculate_btn.Click += new System.EventHandler(this.calculate_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(19, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 109;
            this.label2.Text = "Number of Calls";
            // 
            // num_calls_bx
            // 
            this.num_calls_bx.Location = new System.Drawing.Point(19, 82);
            this.num_calls_bx.Name = "num_calls_bx";
            this.num_calls_bx.Size = new System.Drawing.Size(81, 20);
            this.num_calls_bx.TabIndex = 108;
            this.num_calls_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.add_agents);
            this.panel1.Controls.Add(this.w_shrinkage);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.asa_bx);
            this.panel1.Controls.Add(this.raw_agents);
            this.panel1.Controls.Add(this.max_occ);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.calls_ans);
            this.panel1.Controls.Add(this.prob_wait);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.sla_bx);
            this.panel1.Controls.Add(this.traffic_intesity);
            this.panel1.Location = new System.Drawing.Point(209, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(283, 260);
            this.panel1.TabIndex = 110;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(12, 193);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 13);
            this.label16.TabIndex = 139;
            this.label16.Text = "Maximum Occupancy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 135;
            this.label5.Text = "Additional Agents";
            // 
            // add_agents
            // 
            this.add_agents.Location = new System.Drawing.Point(187, 11);
            this.add_agents.Name = "add_agents";
            this.add_agents.ReadOnly = true;
            this.add_agents.Size = new System.Drawing.Size(81, 20);
            this.add_agents.TabIndex = 134;
            this.add_agents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // w_shrinkage
            // 
            this.w_shrinkage.Location = new System.Drawing.Point(187, 219);
            this.w_shrinkage.Name = "w_shrinkage";
            this.w_shrinkage.ReadOnly = true;
            this.w_shrinkage.Size = new System.Drawing.Size(81, 20);
            this.w_shrinkage.TabIndex = 138;
            this.w_shrinkage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(12, 145);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 132;
            this.label14.Text = "ASA";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 133;
            this.label8.Text = "Raw Agent (N)";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(12, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 26);
            this.label17.TabIndex = 137;
            this.label17.Text = "No. of Required Agents \r\n(W/Shrinkage)";
            // 
            // asa_bx
            // 
            this.asa_bx.Location = new System.Drawing.Point(187, 141);
            this.asa_bx.Name = "asa_bx";
            this.asa_bx.ReadOnly = true;
            this.asa_bx.Size = new System.Drawing.Size(81, 20);
            this.asa_bx.TabIndex = 130;
            this.asa_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raw_agents
            // 
            this.raw_agents.Location = new System.Drawing.Point(187, 63);
            this.raw_agents.Name = "raw_agents";
            this.raw_agents.ReadOnly = true;
            this.raw_agents.Size = new System.Drawing.Size(81, 20);
            this.raw_agents.TabIndex = 131;
            this.raw_agents.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // max_occ
            // 
            this.max_occ.Location = new System.Drawing.Point(187, 193);
            this.max_occ.Name = "max_occ";
            this.max_occ.ReadOnly = true;
            this.max_occ.Size = new System.Drawing.Size(81, 20);
            this.max_occ.TabIndex = 136;
            this.max_occ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(12, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(148, 13);
            this.label13.TabIndex = 128;
            this.label13.Text = "% Calls Answered Immediately";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(12, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(106, 13);
            this.label10.TabIndex = 129;
            this.label10.Text = "Probability of Waiting";
            // 
            // calls_ans
            // 
            this.calls_ans.Location = new System.Drawing.Point(187, 167);
            this.calls_ans.Name = "calls_ans";
            this.calls_ans.ReadOnly = true;
            this.calls_ans.Size = new System.Drawing.Size(81, 20);
            this.calls_ans.TabIndex = 126;
            this.calls_ans.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // prob_wait
            // 
            this.prob_wait.Location = new System.Drawing.Point(187, 89);
            this.prob_wait.Name = "prob_wait";
            this.prob_wait.ReadOnly = true;
            this.prob_wait.Size = new System.Drawing.Size(81, 20);
            this.prob_wait.TabIndex = 127;
            this.prob_wait.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(12, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 124;
            this.label9.Text = "SLA";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(12, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 13);
            this.label12.TabIndex = 125;
            this.label12.Text = "Traffic Intensity (A)";
            // 
            // sla_bx
            // 
            this.sla_bx.Location = new System.Drawing.Point(187, 115);
            this.sla_bx.Name = "sla_bx";
            this.sla_bx.ReadOnly = true;
            this.sla_bx.Size = new System.Drawing.Size(81, 20);
            this.sla_bx.TabIndex = 122;
            this.sla_bx.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // traffic_intesity
            // 
            this.traffic_intesity.Location = new System.Drawing.Point(187, 37);
            this.traffic_intesity.Name = "traffic_intesity";
            this.traffic_intesity.ReadOnly = true;
            this.traffic_intesity.Size = new System.Drawing.Size(81, 20);
            this.traffic_intesity.TabIndex = 123;
            this.traffic_intesity.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(207, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 16);
            this.label15.TabIndex = 111;
            this.label15.Text = "Results";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label18.Location = new System.Drawing.Point(56, 7);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(409, 13);
            this.label18.TabIndex = 112;
            this.label18.Text = "Calculate the number of staff required to reach an agreed service level";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label19.Location = new System.Drawing.Point(17, 333);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 48);
            this.label19.TabIndex = 113;
            this.label19.Text = "*If the results have NaN/Infinite \r\nvalues, Number of calls is \r\ntoo large for th" +
    "e calculation.\r\n\r\n";
            // 
            // TAT_combo_bx
            // 
            this.TAT_combo_bx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TAT_combo_bx.FormattingEnabled = true;
            this.TAT_combo_bx.Items.AddRange(new object[] {
            "0",
            "10",
            "20",
            "30",
            "40"});
            this.TAT_combo_bx.Location = new System.Drawing.Point(19, 163);
            this.TAT_combo_bx.MaxLength = 3;
            this.TAT_combo_bx.Name = "TAT_combo_bx";
            this.TAT_combo_bx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TAT_combo_bx.Size = new System.Drawing.Size(81, 21);
            this.TAT_combo_bx.TabIndex = 100;
            // 
            // Erlang_C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 385);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num_calls_bx);
            this.Controls.Add(this.period_combo_bx);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.shrinkage_bx);
            this.Controls.Add(this.TAT_combo_bx);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.req_sla_bx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AHT_s_bx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.calculate_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Erlang_C";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Erlang Calculator";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox period_combo_bx;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox shrinkage_bx;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox req_sla_bx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AHT_s_bx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculate_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox num_calls_bx;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox add_agents;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox asa_bx;
        private System.Windows.Forms.TextBox raw_agents;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox calls_ans;
        private System.Windows.Forms.TextBox prob_wait;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sla_bx;
        private System.Windows.Forms.TextBox traffic_intesity;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox w_shrinkage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox max_occ;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox TAT_combo_bx;
    }
}

