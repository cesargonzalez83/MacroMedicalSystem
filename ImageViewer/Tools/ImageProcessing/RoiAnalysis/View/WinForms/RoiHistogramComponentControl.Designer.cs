#region License

// Copyright (c) 2006-2007, ClearCanvas Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met:
//
//    * Redistributions of source code must retain the above copyright notice, 
//      this list of conditions and the following disclaimer.
//    * Redistributions in binary form must reproduce the above copyright notice, 
//      this list of conditions and the following disclaimer in the documentation 
//      and/or other materials provided with the distribution.
//    * Neither the name of ClearCanvas Inc. nor the names of its contributors 
//      may be used to endorse or promote products derived from this software without 
//      specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" 
// AND ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, 
// THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR 
// PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR 
// CONTRIBUTORS BE LIABLE FOR ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, 
// OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE 
// GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) 
// HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN 
// ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY 
// OF SUCH DAMAGE.

#endregion

namespace Macro.ImageViewer.Tools.ImageProcessing.RoiAnalysis.View.WinForms
{
    partial class RoiHistogramComponentControl
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
            this._plotSurface = new NPlot.Windows.PlotSurface2D();
            this._autoScaleCheckBox = new System.Windows.Forms.CheckBox();
            this._minUpDown = new System.Windows.Forms.NumericUpDown();
            this._maxUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this._numBinsUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._minUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBinsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // _plotSurface
            // 
            this._plotSurface.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._plotSurface.AutoScaleAutoGeneratedAxes = false;
            this._plotSurface.AutoScaleTitle = false;
            this._plotSurface.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this._plotSurface.DateTimeToolTip = false;
            this._plotSurface.Legend = null;
            this._plotSurface.LegendZOrder = -1;
            this._plotSurface.Location = new System.Drawing.Point(16, 16);
            this._plotSurface.Name = "_plotSurface";
            this._plotSurface.RightMenu = null;
            this._plotSurface.ShowCoordinates = true;
            this._plotSurface.Size = new System.Drawing.Size(354, 260);
            this._plotSurface.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None;
            this._plotSurface.TabIndex = 0;
            this._plotSurface.Text = "plotSurface2D1";
            this._plotSurface.Title = "";
            this._plotSurface.TitleFont = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._plotSurface.XAxis1 = null;
            this._plotSurface.XAxis2 = null;
            this._plotSurface.YAxis1 = null;
            this._plotSurface.YAxis2 = null;
            // 
            // _autoScaleCheckBox
            // 
            this._autoScaleCheckBox.AutoSize = true;
            this._autoScaleCheckBox.Location = new System.Drawing.Point(221, 310);
            this._autoScaleCheckBox.Name = "_autoScaleCheckBox";
            this._autoScaleCheckBox.Size = new System.Drawing.Size(73, 17);
            this._autoScaleCheckBox.TabIndex = 1;
            this._autoScaleCheckBox.Text = "Autoscale";
            this._autoScaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // _minUpDown
            // 
            this._minUpDown.Location = new System.Drawing.Point(16, 314);
            this._minUpDown.Name = "_minUpDown";
            this._minUpDown.Size = new System.Drawing.Size(58, 20);
            this._minUpDown.TabIndex = 2;
            // 
            // _maxUpDown
            // 
            this._maxUpDown.Location = new System.Drawing.Point(95, 314);
            this._maxUpDown.Name = "_maxUpDown";
            this._maxUpDown.Size = new System.Drawing.Size(58, 20);
            this._maxUpDown.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Min";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 291);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Max";
            // 
            // _numBinsUpDown
            // 
            this._numBinsUpDown.Location = new System.Drawing.Point(16, 367);
            this._numBinsUpDown.Name = "_numBinsUpDown";
            this._numBinsUpDown.Size = new System.Drawing.Size(58, 20);
            this._numBinsUpDown.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 347);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bins";
            // 
            // RoiHistogramComponentControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.label3);
            this.Controls.Add(this._numBinsUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._maxUpDown);
            this.Controls.Add(this._minUpDown);
            this.Controls.Add(this._autoScaleCheckBox);
            this.Controls.Add(this._plotSurface);
            this.Name = "RoiHistogramComponentControl";
            this.Size = new System.Drawing.Size(386, 488);
            ((System.ComponentModel.ISupportInitialize)(this._minUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._maxUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numBinsUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

		private NPlot.Windows.PlotSurface2D _plotSurface;
		private System.Windows.Forms.CheckBox _autoScaleCheckBox;
		private System.Windows.Forms.NumericUpDown _minUpDown;
		private System.Windows.Forms.NumericUpDown _maxUpDown;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.NumericUpDown _numBinsUpDown;
		private System.Windows.Forms.Label label3;
    }
}
