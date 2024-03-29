﻿namespace Housesnitcher_GUI.GUI.Controls.Complaints
{
    partial class AdminComplaintControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            this.btnAcknowledge = new System.Windows.Forms.Button();
            this.btnReview = new System.Windows.Forms.Button();
            this.btnResolve = new System.Windows.Forms.Button();
            this.btnInvalidate = new System.Windows.Forms.Button();
            this.lblComplainer = new System.Windows.Forms.Label();
            this.ComplaintControlView = new Housesnitcher_GUI.GUI.Controls.Complaints.ComplaintControl();
            this.ResolvePanel = new System.Windows.Forms.Panel();
            this.btnConfirmReview = new System.Windows.Forms.Button();
            this.tbReviewText = new System.Windows.Forms.RichTextBox();
            this.btnCancelReview = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            this.ResolvePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(69, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(172, 15);
            label1.TabIndex = 2;
            label1.Text = "Write a review of the complaint";
            // 
            // btnAcknowledge
            // 
            this.btnAcknowledge.AutoSize = true;
            this.btnAcknowledge.Enabled = false;
            this.btnAcknowledge.Location = new System.Drawing.Point(306, 16);
            this.btnAcknowledge.Name = "btnAcknowledge";
            this.btnAcknowledge.Size = new System.Drawing.Size(89, 25);
            this.btnAcknowledge.TabIndex = 1;
            this.btnAcknowledge.Text = "Acknowledge";
            this.btnAcknowledge.UseVisualStyleBackColor = true;
            this.btnAcknowledge.Click += new System.EventHandler(this.btnAcknowledge_Click);
            // 
            // btnReview
            // 
            this.btnReview.AutoSize = true;
            this.btnReview.Enabled = false;
            this.btnReview.Location = new System.Drawing.Point(306, 47);
            this.btnReview.Name = "btnReview";
            this.btnReview.Size = new System.Drawing.Size(89, 25);
            this.btnReview.TabIndex = 2;
            this.btnReview.Text = "Review";
            this.btnReview.UseVisualStyleBackColor = true;
            this.btnReview.Click += new System.EventHandler(this.btnReview_Click);
            // 
            // btnResolve
            // 
            this.btnResolve.AutoSize = true;
            this.btnResolve.Enabled = false;
            this.btnResolve.Location = new System.Drawing.Point(306, 78);
            this.btnResolve.Name = "btnResolve";
            this.btnResolve.Size = new System.Drawing.Size(89, 25);
            this.btnResolve.TabIndex = 3;
            this.btnResolve.Text = "Resolve";
            this.btnResolve.UseVisualStyleBackColor = true;
            this.btnResolve.Click += new System.EventHandler(this.btnResolve_Click);
            // 
            // btnInvalidate
            // 
            this.btnInvalidate.AutoSize = true;
            this.btnInvalidate.Location = new System.Drawing.Point(306, 159);
            this.btnInvalidate.Name = "btnInvalidate";
            this.btnInvalidate.Size = new System.Drawing.Size(89, 25);
            this.btnInvalidate.TabIndex = 4;
            this.btnInvalidate.Text = "Invalidate";
            this.btnInvalidate.UseVisualStyleBackColor = true;
            this.btnInvalidate.Click += new System.EventHandler(this.btnInvalidate_Click);
            // 
            // lblComplainer
            // 
            this.lblComplainer.AutoSize = true;
            this.lblComplainer.Location = new System.Drawing.Point(3, 215);
            this.lblComplainer.Name = "lblComplainer";
            this.lblComplainer.Size = new System.Drawing.Size(69, 15);
            this.lblComplainer.TabIndex = 5;
            this.lblComplainer.Text = "Complainer";
            // 
            // ComplaintControlView
            // 
            this.ComplaintControlView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ComplaintControlView.Location = new System.Drawing.Point(-2, -2);
            this.ComplaintControlView.Name = "ComplaintControlView";
            this.ComplaintControlView.Size = new System.Drawing.Size(300, 200);
            this.ComplaintControlView.TabIndex = 6;
            // 
            // ResolvePanel
            // 
            this.ResolvePanel.Controls.Add(this.btnCancelReview);
            this.ResolvePanel.Controls.Add(label1);
            this.ResolvePanel.Controls.Add(this.btnConfirmReview);
            this.ResolvePanel.Controls.Add(this.tbReviewText);
            this.ResolvePanel.Location = new System.Drawing.Point(-2, -2);
            this.ResolvePanel.Name = "ResolvePanel";
            this.ResolvePanel.Size = new System.Drawing.Size(300, 200);
            this.ResolvePanel.TabIndex = 7;
            this.ResolvePanel.Visible = false;
            // 
            // btnConfirmReview
            // 
            this.btnConfirmReview.AutoSize = true;
            this.btnConfirmReview.Location = new System.Drawing.Point(172, 161);
            this.btnConfirmReview.Name = "btnConfirmReview";
            this.btnConfirmReview.Size = new System.Drawing.Size(101, 25);
            this.btnConfirmReview.TabIndex = 1;
            this.btnConfirmReview.Text = "Confirm Review";
            this.btnConfirmReview.UseVisualStyleBackColor = true;
            this.btnConfirmReview.Click += new System.EventHandler(this.btnConfirmReview_Click);
            // 
            // tbReviewText
            // 
            this.tbReviewText.Location = new System.Drawing.Point(5, 49);
            this.tbReviewText.Name = "tbReviewText";
            this.tbReviewText.Size = new System.Drawing.Size(286, 101);
            this.tbReviewText.TabIndex = 0;
            this.tbReviewText.Text = "";
            // 
            // btnCancelReview
            // 
            this.btnCancelReview.AutoSize = true;
            this.btnCancelReview.Location = new System.Drawing.Point(42, 161);
            this.btnCancelReview.Name = "btnCancelReview";
            this.btnCancelReview.Size = new System.Drawing.Size(93, 25);
            this.btnCancelReview.TabIndex = 3;
            this.btnCancelReview.Text = "Cancel Review";
            this.btnCancelReview.UseVisualStyleBackColor = true;
            this.btnCancelReview.Click += new System.EventHandler(this.btnCancelReview_Click);
            // 
            // AdminComplaintControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.ResolvePanel);
            this.Controls.Add(this.ComplaintControlView);
            this.Controls.Add(this.lblComplainer);
            this.Controls.Add(this.btnInvalidate);
            this.Controls.Add(this.btnResolve);
            this.Controls.Add(this.btnReview);
            this.Controls.Add(this.btnAcknowledge);
            this.Name = "AdminComplaintControl";
            this.Size = new System.Drawing.Size(400, 250);
            this.ResolvePanel.ResumeLayout(false);
            this.ResolvePanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAcknowledge;
        private Button btnReview;
        private Button btnResolve;
        private Button btnInvalidate;
        private Label lblComplainer;
        private ComplaintControl ComplaintControlView;
        private Panel ResolvePanel;
        private Button btnConfirmReview;
        private RichTextBox tbReviewText;
        private Label label1;
        private Button btnCancelReview;
    }
}
