namespace SedapMakanSystem
{
    partial class CustomerMainForm
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.btnSendFeedback = new System.Windows.Forms.Button();
            this.btnCancelOrder = new System.Windows.Forms.Button();
            this.btnOrderStatus = new System.Windows.Forms.Button();
            this.btnBrowseOrder = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Location = new System.Drawing.Point(258, 33);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(106, 13);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Customer Dashboard";
            this.lblWelcome.Click += new System.EventHandler(this.lblWelcome_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateProfile);
            this.panel1.Controls.Add(this.btnSendFeedback);
            this.panel1.Controls.Add(this.btnCancelOrder);
            this.panel1.Controls.Add(this.btnOrderStatus);
            this.panel1.Controls.Add(this.btnBrowseOrder);
            this.panel1.Location = new System.Drawing.Point(179, 62);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 172);
            this.panel1.TabIndex = 1;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.Location = new System.Drawing.Point(19, 131);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(236, 23);
            this.btnUpdateProfile.TabIndex = 4;
            this.btnUpdateProfile.Text = "Update Profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = true;
            // 
            // btnSendFeedback
            // 
            this.btnSendFeedback.Location = new System.Drawing.Point(19, 102);
            this.btnSendFeedback.Name = "btnSendFeedback";
            this.btnSendFeedback.Size = new System.Drawing.Size(236, 23);
            this.btnSendFeedback.TabIndex = 3;
            this.btnSendFeedback.Text = "Send Feedback";
            this.btnSendFeedback.UseVisualStyleBackColor = true;
            // 
            // btnCancelOrder
            // 
            this.btnCancelOrder.Location = new System.Drawing.Point(19, 73);
            this.btnCancelOrder.Name = "btnCancelOrder";
            this.btnCancelOrder.Size = new System.Drawing.Size(236, 23);
            this.btnCancelOrder.TabIndex = 2;
            this.btnCancelOrder.Text = "Cancel Order / Request Refund";
            this.btnCancelOrder.UseVisualStyleBackColor = true;
            // 
            // btnOrderStatus
            // 
            this.btnOrderStatus.Location = new System.Drawing.Point(19, 44);
            this.btnOrderStatus.Name = "btnOrderStatus";
            this.btnOrderStatus.Size = new System.Drawing.Size(236, 23);
            this.btnOrderStatus.TabIndex = 1;
            this.btnOrderStatus.Text = "View Order Status & Refunds";
            this.btnOrderStatus.UseVisualStyleBackColor = true;
            // 
            // btnBrowseOrder
            // 
            this.btnBrowseOrder.Location = new System.Drawing.Point(19, 15);
            this.btnBrowseOrder.Name = "btnBrowseOrder";
            this.btnBrowseOrder.Size = new System.Drawing.Size(236, 23);
            this.btnBrowseOrder.TabIndex = 0;
            this.btnBrowseOrder.Text = "Browse Menu & Order";
            this.btnBrowseOrder.UseVisualStyleBackColor = true;
            // 
            // CustomerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 319);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblWelcome);
            this.Name = "CustomerMainForm";
            this.Text = "CustomerMainForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUpdateProfile;
        private System.Windows.Forms.Button btnSendFeedback;
        private System.Windows.Forms.Button btnCancelOrder;
        private System.Windows.Forms.Button btnOrderStatus;
        private System.Windows.Forms.Button btnBrowseOrder;
    }
}

