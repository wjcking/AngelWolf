﻿namespace AngelLayout
{
    partial class Wrabber
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Wrabber));
            this.angelView = new AngelLayout.AngelView(this.components);
            this.SuspendLayout();
            // 
            // angelView
            // 
            resources.ApplyResources(this.angelView, "angelView");
            this.angelView.Name = "angelView";
            this.angelView.ScrollBarsEnabled = false;
            this.angelView.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.angelView_Navigated);
            // 
            // Wrabber
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.angelView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Wrabber";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion
        private AngelView angelView;
    }
}
