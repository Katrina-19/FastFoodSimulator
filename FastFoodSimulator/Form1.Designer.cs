
namespace FastFoodSimulator
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_timeOfBuyers = new System.Windows.Forms.TextBox();
            this.tb_timeOfOrder = new System.Windows.Forms.TextBox();
            this.tb_cookingTime = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.readyId = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cookedId = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.orderId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buyerId = new System.Windows.Forms.Label();
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "appearance\r\nof buyers";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 34);
            this.label2.TabIndex = 1;
            this.label2.Text = "time to place\r\nan order";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "cooking time";
            // 
            // tb_timeOfBuyers
            // 
            this.tb_timeOfBuyers.Location = new System.Drawing.Point(116, 27);
            this.tb_timeOfBuyers.Name = "tb_timeOfBuyers";
            this.tb_timeOfBuyers.Size = new System.Drawing.Size(100, 22);
            this.tb_timeOfBuyers.TabIndex = 3;
            this.tb_timeOfBuyers.TextChanged += new System.EventHandler(this.tb_timeOfBuyers_TextChanged);
            // 
            // tb_timeOfOrder
            // 
            this.tb_timeOfOrder.Location = new System.Drawing.Point(116, 97);
            this.tb_timeOfOrder.Name = "tb_timeOfOrder";
            this.tb_timeOfOrder.Size = new System.Drawing.Size(100, 22);
            this.tb_timeOfOrder.TabIndex = 4;
            // 
            // tb_cookingTime
            // 
            this.tb_cookingTime.Location = new System.Drawing.Point(116, 168);
            this.tb_cookingTime.Name = "tb_cookingTime";
            this.tb_cookingTime.Size = new System.Drawing.Size(100, 22);
            this.tb_cookingTime.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(241, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(547, 426);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Simulator";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.readyId);
            this.groupBox5.Location = new System.Drawing.Point(308, 233);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 165);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "ready orders";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(161, 17);
            this.label10.TabIndex = 14;
            this.label10.Text = "the Id of the ready order";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // readyId
            // 
            this.readyId.AutoSize = true;
            this.readyId.Location = new System.Drawing.Point(73, 121);
            this.readyId.Name = "readyId";
            this.readyId.Size = new System.Drawing.Size(0, 17);
            this.readyId.TabIndex = 15;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.cookedId);
            this.groupBox4.Location = new System.Drawing.Point(16, 233);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 165);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "kitchen";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "the Id of the cooked order";
            // 
            // cookedId
            // 
            this.cookedId.AutoSize = true;
            this.cookedId.Location = new System.Drawing.Point(73, 121);
            this.cookedId.Name = "cookedId";
            this.cookedId.Size = new System.Drawing.Size(0, 17);
            this.cookedId.TabIndex = 13;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.orderId);
            this.groupBox3.Location = new System.Drawing.Point(308, 31);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 165);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "order";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "the Id of the order";
            // 
            // orderId
            // 
            this.orderId.AutoSize = true;
            this.orderId.Location = new System.Drawing.Point(81, 125);
            this.orderId.Name = "orderId";
            this.orderId.Size = new System.Drawing.Size(0, 17);
            this.orderId.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.buyerId);
            this.groupBox2.Location = new System.Drawing.Point(16, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 165);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "queue";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 34);
            this.label4.TabIndex = 8;
            this.label4.Text = "the Id of the ordering \r\ncustomer";
            // 
            // buyerId
            // 
            this.buyerId.AutoSize = true;
            this.buyerId.Location = new System.Drawing.Point(73, 125);
            this.buyerId.Name = "buyerId";
            this.buyerId.Size = new System.Drawing.Size(0, 17);
            this.buyerId.TabIndex = 9;
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(29, 387);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(134, 387);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 7;
            this.btn_stop.Text = "stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_cookingTime);
            this.Controls.Add(this.tb_timeOfOrder);
            this.Controls.Add(this.tb_timeOfBuyers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_timeOfBuyers;
        private System.Windows.Forms.TextBox tb_timeOfOrder;
        private System.Windows.Forms.TextBox tb_cookingTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label readyId;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label cookedId;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label orderId;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label buyerId;
    }
}

