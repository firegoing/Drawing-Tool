
namespace Drawing_Tool
{
    partial class MainForm
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
            this.funcPanel = new Sunny.UI.UIPanel();
            this.btnClear = new Sunny.UI.UIButton();
            this.btnSave = new Sunny.UI.UIButton();
            this.pnlColor = new Sunny.UI.UIPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnColor = new Sunny.UI.UIButton();
            this.pnlSize = new Sunny.UI.UIPanel();
            this.btnSize4 = new Sunny.UI.UIButton();
            this.btnSize3 = new Sunny.UI.UIButton();
            this.btnSize2 = new Sunny.UI.UIButton();
            this.btnSize1 = new Sunny.UI.UIButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlShape = new Sunny.UI.UIPanel();
            this.btnShape6 = new Sunny.UI.UISymbolButton();
            this.btnShape5 = new Sunny.UI.UISymbolButton();
            this.btnShape4 = new Sunny.UI.UISymbolButton();
            this.btnShape3 = new Sunny.UI.UISymbolButton();
            this.btnShape2 = new Sunny.UI.UISymbolButton();
            this.btnShape1 = new Sunny.UI.UISymbolButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlTool = new Sunny.UI.UIPanel();
            this.btnEraser = new Sunny.UI.UISymbolButton();
            this.btnPencil = new Sunny.UI.UISymbolButton();
            this.label1 = new System.Windows.Forms.Label();
            this.picBoxtarget = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.picboxInter = new System.Windows.Forms.PictureBox();
            this.btnShape8 = new Sunny.UI.UISymbolButton();
            this.btnShape7 = new Sunny.UI.UISymbolButton();
            this.funcPanel.SuspendLayout();
            this.pnlColor.SuspendLayout();
            this.pnlSize.SuspendLayout();
            this.pnlShape.SuspendLayout();
            this.pnlTool.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxtarget)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInter)).BeginInit();
            this.SuspendLayout();
            // 
            // funcPanel
            // 
            this.funcPanel.Controls.Add(this.btnClear);
            this.funcPanel.Controls.Add(this.btnSave);
            this.funcPanel.Controls.Add(this.pnlColor);
            this.funcPanel.Controls.Add(this.pnlSize);
            this.funcPanel.Controls.Add(this.pnlShape);
            this.funcPanel.Controls.Add(this.pnlTool);
            this.funcPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcPanel.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.funcPanel.Location = new System.Drawing.Point(0, 35);
            this.funcPanel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.funcPanel.MinimumSize = new System.Drawing.Size(1, 1);
            this.funcPanel.Name = "funcPanel";
            this.funcPanel.Radius = 0;
            this.funcPanel.RectSize = 2;
            this.funcPanel.Size = new System.Drawing.Size(1000, 100);
            this.funcPanel.TabIndex = 1;
            this.funcPanel.Text = null;
            this.funcPanel.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.funcPanel.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnClear
            // 
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.Location = new System.Drawing.Point(576, 60);
            this.btnClear.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 35);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "清空画布";
            this.btnClear.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.Location = new System.Drawing.Point(690, 60);
            this.btnSave.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 35);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "保存图片";
            this.btnSave.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSave.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pnlColor
            // 
            this.pnlColor.Controls.Add(this.label3);
            this.pnlColor.Controls.Add(this.btnColor);
            this.pnlColor.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlColor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlColor.Location = new System.Drawing.Point(439, 0);
            this.pnlColor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlColor.Name = "pnlColor";
            this.pnlColor.Radius = 0;
            this.pnlColor.RectSize = 2;
            this.pnlColor.Size = new System.Drawing.Size(130, 100);
            this.pnlColor.TabIndex = 5;
            this.pnlColor.Text = null;
            this.pnlColor.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlColor.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "颜色";
            // 
            // btnColor
            // 
            this.btnColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnColor.FillColor = System.Drawing.Color.Red;
            this.btnColor.FillColor2 = System.Drawing.Color.Red;
            this.btnColor.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnColor.Location = new System.Drawing.Point(34, 15);
            this.btnColor.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(60, 49);
            this.btnColor.Style = Sunny.UI.UIStyle.Custom;
            this.btnColor.StyleCustomMode = true;
            this.btnColor.TabIndex = 2;
            this.btnColor.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnColor, "单击设置画笔颜色");
            this.btnColor.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // pnlSize
            // 
            this.pnlSize.Controls.Add(this.btnSize4);
            this.pnlSize.Controls.Add(this.btnSize3);
            this.pnlSize.Controls.Add(this.btnSize2);
            this.pnlSize.Controls.Add(this.btnSize1);
            this.pnlSize.Controls.Add(this.label8);
            this.pnlSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSize.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlSize.Location = new System.Drawing.Point(309, 0);
            this.pnlSize.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlSize.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlSize.Name = "pnlSize";
            this.pnlSize.Radius = 0;
            this.pnlSize.RectSize = 2;
            this.pnlSize.Size = new System.Drawing.Size(130, 100);
            this.pnlSize.TabIndex = 4;
            this.pnlSize.Text = null;
            this.pnlSize.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlSize.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnSize4
            // 
            this.btnSize4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSize4.FillColor = System.Drawing.Color.Black;
            this.btnSize4.FillColor2 = System.Drawing.Color.Red;
            this.btnSize4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSize4.Location = new System.Drawing.Point(14, 55);
            this.btnSize4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSize4.Name = "btnSize4";
            this.btnSize4.Radius = 4;
            this.btnSize4.Size = new System.Drawing.Size(102, 16);
            this.btnSize4.Style = Sunny.UI.UIStyle.Custom;
            this.btnSize4.StyleCustomMode = true;
            this.btnSize4.TabIndex = 6;
            this.btnSize4.Tag = "8px";
            this.btnSize4.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnSize4, "8px");
            this.btnSize4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSize4.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnSize3
            // 
            this.btnSize3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSize3.FillColor = System.Drawing.Color.Black;
            this.btnSize3.FillColor2 = System.Drawing.Color.Red;
            this.btnSize3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSize3.Location = new System.Drawing.Point(14, 36);
            this.btnSize3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSize3.Name = "btnSize3";
            this.btnSize3.Radius = 4;
            this.btnSize3.Size = new System.Drawing.Size(102, 12);
            this.btnSize3.Style = Sunny.UI.UIStyle.Custom;
            this.btnSize3.StyleCustomMode = true;
            this.btnSize3.TabIndex = 5;
            this.btnSize3.Tag = "6px";
            this.btnSize3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnSize3, "6px");
            this.btnSize3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSize3.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnSize2
            // 
            this.btnSize2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSize2.FillColor = System.Drawing.Color.Black;
            this.btnSize2.FillColor2 = System.Drawing.Color.Red;
            this.btnSize2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSize2.Location = new System.Drawing.Point(14, 21);
            this.btnSize2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSize2.Name = "btnSize2";
            this.btnSize2.Radius = 4;
            this.btnSize2.Size = new System.Drawing.Size(102, 8);
            this.btnSize2.Style = Sunny.UI.UIStyle.Custom;
            this.btnSize2.StyleCustomMode = true;
            this.btnSize2.TabIndex = 4;
            this.btnSize2.Tag = "4px";
            this.btnSize2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnSize2, "4px");
            this.btnSize2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSize2.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // btnSize1
            // 
            this.btnSize1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSize1.FillColor = System.Drawing.Color.Black;
            this.btnSize1.FillColor2 = System.Drawing.Color.Red;
            this.btnSize1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSize1.Location = new System.Drawing.Point(14, 10);
            this.btnSize1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnSize1.Name = "btnSize1";
            this.btnSize1.Radius = 4;
            this.btnSize1.Size = new System.Drawing.Size(102, 4);
            this.btnSize1.Style = Sunny.UI.UIStyle.Custom;
            this.btnSize1.StyleCustomMode = true;
            this.btnSize1.TabIndex = 3;
            this.btnSize1.Tag = "2px";
            this.btnSize1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnSize1, "2px");
            this.btnSize1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnSize1.Click += new System.EventHandler(this.btnSize_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "粗细";
            // 
            // pnlShape
            // 
            this.pnlShape.Controls.Add(this.btnShape8);
            this.pnlShape.Controls.Add(this.btnShape7);
            this.pnlShape.Controls.Add(this.btnShape6);
            this.pnlShape.Controls.Add(this.btnShape5);
            this.pnlShape.Controls.Add(this.btnShape4);
            this.pnlShape.Controls.Add(this.btnShape3);
            this.pnlShape.Controls.Add(this.btnShape2);
            this.pnlShape.Controls.Add(this.btnShape1);
            this.pnlShape.Controls.Add(this.label2);
            this.pnlShape.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlShape.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlShape.Location = new System.Drawing.Point(130, 0);
            this.pnlShape.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlShape.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlShape.Name = "pnlShape";
            this.pnlShape.Radius = 0;
            this.pnlShape.RectSize = 2;
            this.pnlShape.Size = new System.Drawing.Size(179, 100);
            this.pnlShape.TabIndex = 3;
            this.pnlShape.Text = null;
            this.pnlShape.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlShape.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnShape6
            // 
            this.btnShape6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape6.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape6.Location = new System.Drawing.Point(97, 45);
            this.btnShape6.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape6.Name = "btnShape6";
            this.btnShape6.Size = new System.Drawing.Size(26, 27);
            this.btnShape6.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape6.StyleCustomMode = true;
            this.btnShape6.Symbol = 57393;
            this.btnShape6.TabIndex = 7;
            this.btnShape6.Tag = "fivepStart";
            this.btnShape6.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape6, "五角星形");
            this.btnShape6.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape6.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnShape5
            // 
            this.btnShape5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape5.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape5.Location = new System.Drawing.Point(52, 45);
            this.btnShape5.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape5.Name = "btnShape5";
            this.btnShape5.Size = new System.Drawing.Size(26, 28);
            this.btnShape5.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape5.StyleCustomMode = true;
            this.btnShape5.Symbol = 61515;
            this.btnShape5.TabIndex = 6;
            this.btnShape5.Tag = "triangle";
            this.btnShape5.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape5, "无填充等腰三角形");
            this.btnShape5.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape5.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnShape4
            // 
            this.btnShape4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape4.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape4.Location = new System.Drawing.Point(7, 45);
            this.btnShape4.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape4.Name = "btnShape4";
            this.btnShape4.Size = new System.Drawing.Size(26, 28);
            this.btnShape4.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape4.StyleCustomMode = true;
            this.btnShape4.Symbol = 261640;
            this.btnShape4.TabIndex = 5;
            this.btnShape4.Tag = "rectangle";
            this.btnShape4.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape4, "矩形");
            this.btnShape4.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape4.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnShape3
            // 
            this.btnShape3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape3.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape3.Location = new System.Drawing.Point(97, 9);
            this.btnShape3.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape3.Name = "btnShape3";
            this.btnShape3.Size = new System.Drawing.Size(26, 30);
            this.btnShape3.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape3.StyleCustomMode = true;
            this.btnShape3.Symbol = 61708;
            this.btnShape3.TabIndex = 4;
            this.btnShape3.Tag = "circle";
            this.btnShape3.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape3, "椭圆");
            this.btnShape3.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape3.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnShape2
            // 
            this.btnShape2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape2.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape2.Location = new System.Drawing.Point(52, 9);
            this.btnShape2.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape2.Name = "btnShape2";
            this.btnShape2.Size = new System.Drawing.Size(26, 30);
            this.btnShape2.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape2.StyleCustomMode = true;
            this.btnShape2.Symbol = 262161;
            this.btnShape2.TabIndex = 3;
            this.btnShape2.Tag = "line";
            this.btnShape2.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape2, "直线");
            this.btnShape2.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape2.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnShape1
            // 
            this.btnShape1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape1.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape1.Location = new System.Drawing.Point(7, 9);
            this.btnShape1.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape1.Name = "btnShape1";
            this.btnShape1.Size = new System.Drawing.Size(26, 29);
            this.btnShape1.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape1.StyleCustomMode = true;
            this.btnShape1.Symbol = 363550;
            this.btnShape1.TabIndex = 2;
            this.btnShape1.Tag = "curve";
            this.btnShape1.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape1, "曲线");
            this.btnShape1.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape1.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "形状";
            // 
            // pnlTool
            // 
            this.pnlTool.Controls.Add(this.btnEraser);
            this.pnlTool.Controls.Add(this.btnPencil);
            this.pnlTool.Controls.Add(this.label1);
            this.pnlTool.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlTool.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlTool.Location = new System.Drawing.Point(0, 0);
            this.pnlTool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlTool.MinimumSize = new System.Drawing.Size(1, 1);
            this.pnlTool.Name = "pnlTool";
            this.pnlTool.Radius = 0;
            this.pnlTool.RectSize = 2;
            this.pnlTool.Size = new System.Drawing.Size(130, 100);
            this.pnlTool.TabIndex = 2;
            this.pnlTool.Text = null;
            this.pnlTool.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.pnlTool.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            // 
            // btnEraser
            // 
            this.btnEraser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEraser.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnEraser.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnEraser.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnEraser.Location = new System.Drawing.Point(70, 21);
            this.btnEraser.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(54, 38);
            this.btnEraser.Style = Sunny.UI.UIStyle.Custom;
            this.btnEraser.StyleCustomMode = true;
            this.btnEraser.Symbol = 61741;
            this.btnEraser.TabIndex = 9;
            this.btnEraser.Tag = "eraser";
            this.btnEraser.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnEraser, "橡皮擦");
            this.btnEraser.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnEraser.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnPencil
            // 
            this.btnPencil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPencil.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPencil.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnPencil.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnPencil.Location = new System.Drawing.Point(7, 21);
            this.btnPencil.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnPencil.Name = "btnPencil";
            this.btnPencil.Size = new System.Drawing.Size(54, 38);
            this.btnPencil.Style = Sunny.UI.UIStyle.Custom;
            this.btnPencil.StyleCustomMode = true;
            this.btnPencil.Symbol = 361947;
            this.btnPencil.TabIndex = 8;
            this.btnPencil.Tag = "pencil";
            this.btnPencil.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnPencil, "画笔");
            this.btnPencil.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnPencil.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "工具";
            // 
            // picBoxtarget
            // 
            this.picBoxtarget.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picBoxtarget.BackColor = System.Drawing.Color.White;
            this.picBoxtarget.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.picBoxtarget.Location = new System.Drawing.Point(2, 138);
            this.picBoxtarget.Name = "picBoxtarget";
            this.picBoxtarget.Size = new System.Drawing.Size(995, 559);
            this.picBoxtarget.TabIndex = 2;
            this.picBoxtarget.TabStop = false;
            this.picBoxtarget.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxtarget_MouseDown);
            this.picBoxtarget.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxtarget_MouseMove);
            this.picBoxtarget.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxtarget_MouseUp);
            // 
            // picboxInter
            // 
            this.picboxInter.BackColor = System.Drawing.Color.Transparent;
            this.picboxInter.Location = new System.Drawing.Point(2, 138);
            this.picboxInter.Name = "picboxInter";
            this.picboxInter.Size = new System.Drawing.Size(995, 559);
            this.picboxInter.TabIndex = 3;
            this.picboxInter.TabStop = false;
            this.picboxInter.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picBoxtarget_MouseDown);
            this.picboxInter.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picBoxtarget_MouseMove);
            this.picboxInter.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picBoxtarget_MouseUp);
            // 
            // btnShape8
            // 
            this.btnShape8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape8.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape8.Location = new System.Drawing.Point(142, 45);
            this.btnShape8.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape8.Name = "btnShape8";
            this.btnShape8.Size = new System.Drawing.Size(26, 27);
            this.btnShape8.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape8.StyleCustomMode = true;
            this.btnShape8.Symbol = 94;
            this.btnShape8.TabIndex = 9;
            this.btnShape8.Tag = "spot";
            this.btnShape8.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape8, "点");
            this.btnShape8.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape8.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // btnShape7
            // 
            this.btnShape7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShape7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnShape7.FillDisableColor = System.Drawing.Color.Aqua;
            this.btnShape7.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnShape7.Location = new System.Drawing.Point(142, 9);
            this.btnShape7.MinimumSize = new System.Drawing.Size(1, 1);
            this.btnShape7.Name = "btnShape7";
            this.btnShape7.Size = new System.Drawing.Size(26, 30);
            this.btnShape7.Style = Sunny.UI.UIStyle.Custom;
            this.btnShape7.StyleCustomMode = true;
            this.btnShape7.Symbol = 61517;
            this.btnShape7.TabIndex = 8;
            this.btnShape7.Tag = "fillrec";
            this.btnShape7.TipsFont = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.toolTip.SetToolTip(this.btnShape7, "纯色填充矩形");
            this.btnShape7.ZoomScaleRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.btnShape7.Click += new System.EventHandler(this.btnShape_Click);
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.picboxInter);
            this.Controls.Add(this.picBoxtarget);
            this.Controls.Add(this.funcPanel);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowTitleIcon = true;
            this.Text = "Drawing tool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.funcPanel.ResumeLayout(false);
            this.pnlColor.ResumeLayout(false);
            this.pnlColor.PerformLayout();
            this.pnlSize.ResumeLayout(false);
            this.pnlSize.PerformLayout();
            this.pnlShape.ResumeLayout(false);
            this.pnlShape.PerformLayout();
            this.pnlTool.ResumeLayout(false);
            this.pnlTool.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxtarget)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxInter)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIPanel funcPanel;
        private Sunny.UI.UIPanel pnlColor;
        private System.Windows.Forms.Label label3;
        private Sunny.UI.UIPanel pnlSize;
        private Sunny.UI.UIPanel pnlShape;
        private System.Windows.Forms.Label label2;
        private Sunny.UI.UIPanel pnlTool;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private Sunny.UI.UIButton btnColor;
        private Sunny.UI.UIButton btnSize4;
        private Sunny.UI.UIButton btnSize3;
        private Sunny.UI.UIButton btnSize2;
        private Sunny.UI.UIButton btnSize1;
        private Sunny.UI.UISymbolButton btnShape1;
        private Sunny.UI.UISymbolButton btnShape6;
        private Sunny.UI.UISymbolButton btnShape5;
        private Sunny.UI.UISymbolButton btnShape4;
        private Sunny.UI.UISymbolButton btnShape3;
        private Sunny.UI.UISymbolButton btnShape2;
        private Sunny.UI.UISymbolButton btnEraser;
        private Sunny.UI.UISymbolButton btnPencil;
        private System.Windows.Forms.PictureBox picBoxtarget;
        private System.Windows.Forms.ToolTip toolTip;
        private Sunny.UI.UIButton btnClear;
        private Sunny.UI.UIButton btnSave;
        private System.Windows.Forms.PictureBox picboxInter;
        private Sunny.UI.UISymbolButton btnShape8;
        private Sunny.UI.UISymbolButton btnShape7;
    }
}

