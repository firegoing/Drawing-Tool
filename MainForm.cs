using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sunny.UI;

namespace Drawing_Tool
{
    public partial class MainForm : BaseForm
    {
        /// <summary>
        /// 起始点
        /// </summary>
        private PointF startPoint;
        /// <summary>
        /// 当前点
        /// </summary>
        private PointF currentPoint;
        /// <summary>
        /// 目标画板的图面
        /// </summary>
        private Graphics targetGraphics;
        /// <summary>
        /// 目标画板上的图形
        /// </summary>
        private Bitmap targetImage;
        /// <summary>
        /// 中间画板
        /// </summary>
        private Graphics interGraphics;
        /// <summary>
        /// 中间画板上的图形
        /// </summary>
        private Bitmap interImage;
        /// <summary>
        /// 要放入画板的新图像
        /// </summary>
        private Image originalImage;
        /// <summary>
        /// 我的画笔
        /// </summary>
        private Pen myPen;
        /// <summary>
        /// 指示是否开始作画  
        /// </summary>
        bool beginPaint = false;
        /// <summary>
        /// 指示鼠标移动时是否要画线
        /// </summary>
        bool beginMove = false;
        /// <summary>
        /// 画图的类型
        /// </summary>
        DrawType drawType;
        
        public MainForm()
        {
            InitializeComponent();
            
        }
        private enum DrawType
        {
            curve = 0,
            line = 1,
            circle = 2,
            rectangle = 3,
            triangle = 4,
            fivepStart = 5,
            eraser = 6,
            fillRectangle = 7,
            spot = 8
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            UIButton button = sender as UIButton;
            if (button == null) return;
            ColorDialog colorForm = new ColorDialog();
            DialogResult r = colorForm.ShowDialog();
            if (r == DialogResult.Yes || r == DialogResult.OK)
            {
                button.FillColor = Color.FromArgb(255, colorForm.Color);   
            }
            myPen.Color = button.FillColor;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //实例化画笔
            myPen = new Pen(Color.Red, 2);
            //实例化中间画板上的位图
            interImage = new Bitmap(picBoxtarget.Width, picBoxtarget.Height);
            targetImage = new Bitmap(picBoxtarget.Width, picBoxtarget.Height);
            //初始化画图类型
            drawType = DrawType.curve;
            //在位图中建立目标画板
            targetGraphics = Graphics.FromImage(targetImage);
            picboxInter.Parent = picBoxtarget;            //因为设置了中间的box为透明  要指定父级控件 透明效果才能出来
            picboxInter.Location = new Point(0, 0);     //指定父级控件后  需要重新赋予位置和大小
            picboxInter.Width = picBoxtarget.Width;
            picboxInter.Height = picBoxtarget.Height;

            btnSize1.FillColor = btnSize1.FillHoverColor;
            btnSize2.FillColor = Color.Black;
            btnSize3.FillColor = Color.Black;
            btnSize4.FillColor = Color.Black;


        }

        private void btnShape_Click(object sender, EventArgs e)
        {
            UIButton btn = sender as UIButton;
            beginPaint = true;
            picBoxtarget.Cursor = Cursors.PanNW;    //除了橡皮擦的cursor不一样外 其他的cursor都为PanNW
            switch (btn.Tag.ToString().ToLower())
            {
                case "curve":                     //pencil和画曲线是一样的
                case "pencil":           
                    drawType = DrawType.curve;
                    break;
                case "line":
                    drawType = DrawType.line;
                    break;
                case "circle":
                    drawType = DrawType.circle;
                    break;
                case "rectangle":
                    drawType = DrawType.rectangle;
                    break;
                case "triangle":
                    drawType = DrawType.triangle;
                    break;
                case "fivepstart":
                    drawType = DrawType.fivepStart;
                    break;
                case "eraser":
                    drawType = DrawType.eraser;
                    picBoxtarget.Cursor = Cursors.No;
                    break;
                case "fillrec":
                    drawType = DrawType.fillRectangle;
                    break;
                case "spot":
                    drawType = DrawType.spot;
                    break;
                default:
                    break;
            }
        }

        private void picBoxtarget_MouseDown(object sender, MouseEventArgs e)
        {
            if (!beginPaint) return;
            if (e.Button == MouseButtons.Left)   //判断是否是左键点击
            {
                beginMove = true;
                startPoint = new PointF(e.X-8, e.Y-8);
            }
            if (drawType == DrawType.spot)    
            {
                currentPoint = new PointF(e.X-8, e.Y-8);
                targetGraphics.DrawPoint(myPen.Color,currentPoint,myPen.Width);
                picBoxtarget.Image = targetImage;
                beginMove = false;
            }
        }

        private void picBoxtarget_MouseMove(object sender, MouseEventArgs e)
        {
            if (beginMove && drawType != DrawType.spot)   //画点不用响应Move事件
            {
                float leftX = startPoint.X;
                float leftY = startPoint.Y;
                currentPoint = new PointF(e.X - 8, e.Y - 8);   //
                float width = currentPoint.X - startPoint.X;
                float height = currentPoint.Y - startPoint.Y;
                interImage = new Bitmap(picBoxtarget.Width, picBoxtarget.Height); //每次鼠标移动 清空中间图像
                interGraphics = Graphics.FromImage(interImage);
                switch (drawType)
                {
                    case DrawType.curve:
                        currentPoint = new PointF(e.X, e.Y);
                        targetGraphics.DrawLine(myPen, startPoint, currentPoint);
                        picBoxtarget.Image = targetImage;
                        startPoint = currentPoint;
                        break;
                    case DrawType.line:
                        interGraphics.DrawLine(myPen, startPoint, currentPoint);
                        originalImage = interImage.Clone() as Image;
                        picboxInter.Image = interImage;
                        break;
                    case DrawType.circle:
                        interGraphics.DrawEllipse(myPen, leftX, leftY, width, height);
                        originalImage = interImage.Clone() as Image;
                        picboxInter.Image = interImage;
                        break;
                    case DrawType.rectangle:
                        interGraphics.DrawRectangle(myPen, leftX, leftY, width, height);
                        originalImage = interImage.Clone() as Image;
                        picboxInter.Image = interImage;
                        break;
                    case DrawType.fillRectangle:
                        interGraphics.FillRectangle(new SolidBrush(myPen.Color), leftX, leftY, width, height);
                        originalImage = interImage.Clone() as Image;
                        picboxInter.Image = interImage;
                        break;
                    case DrawType.triangle:          //等腰三角形
                        PointF[] pointfs = { new PointF((startPoint.X + currentPoint.X) / 2, startPoint.Y), new PointF(startPoint.X, currentPoint.Y), currentPoint };  //三点确定一个三角形
                        interGraphics.DrawPolygon(myPen, pointfs);
                        originalImage = interImage.Clone() as Image;
                        picboxInter.Image = interImage;
                        break;
                    case DrawType.fivepStart:
                        PointF[] pointFs;
                        pointFs = GetPointFs(startPoint, currentPoint);
                        interGraphics.DrawPolygon(myPen, pointFs);
                        originalImage = interImage.Clone() as Image;
                        picboxInter.Image = interImage;
                        break;
                    case DrawType.eraser:        //橡皮檫相当于用白色填充的矩形覆盖图形
                        targetGraphics.FillRectangle(new SolidBrush(picBoxtarget.BackColor), startPoint.X, startPoint.Y, 16, 16);
                        picBoxtarget.Image = targetImage;
                        startPoint = currentPoint;
                        break;
                    default:
                        break;
                }

                GC.Collect();  //创建副本很占内存  每次都垃圾回收一下
            }
        }

        /// <summary>
        /// 通过两个坐标点  获取五角星（不标准五角星）的10个点 
        /// </summary>
        /// <param name="firstP"></param>
        /// <param name="secondP"></param>
        /// <returns></returns>
        private static PointF[] GetPointFs(PointF firstP, PointF secondP)
        {
            //最左上角X,Y为零
            PointF[] pointFs = new PointF[10];
            pointFs[0] = new PointF((firstP.X + secondP.X) / 2, firstP.Y);   //最顶端的第一个点
            pointFs[1] = new PointF(firstP.X + (secondP.X - firstP.X) * 3 / 5, firstP.Y + (secondP.Y - firstP.Y) / 3);//第二层第三个点
            pointFs[2] = new PointF(secondP.X, firstP.Y + (secondP.Y - firstP.Y) / 3);  //第二层第四个点
            pointFs[3] = new PointF(firstP.X + (secondP.X - firstP.X) * 2 / 3, firstP.Y + (secondP.Y - firstP.Y) * 3 / 5); //第三层第二个点
            pointFs[4] = new PointF(firstP.X + (secondP.X - firstP.X) * 4 / 5, secondP.Y);//最后一层第二个点
            pointFs[5] = new PointF((firstP.X + secondP.X) / 2, firstP.Y + (secondP.Y - firstP.Y) * 3 / 4);  //倒数第二层的点
            pointFs[6] = new PointF(firstP.X + (secondP.X - firstP.X) / 5, secondP.Y);   //最后一层第一个点
            pointFs[7] = new PointF(firstP.X + (secondP.X - firstP.X) / 3, firstP.Y + (secondP.Y - firstP.Y) * 3 / 5);  //第三层第一个点
            pointFs[8] = new PointF(firstP.X, firstP.Y + (secondP.Y - firstP.Y) / 3);  //第二层第一个点
            pointFs[9] = new PointF(firstP.X + (secondP.X - firstP.X) * 2 / 5, firstP.Y + (secondP.Y - firstP.Y) / 3);//第二层第二个点
            return pointFs;
        }

        private void picBoxtarget_MouseUp(object sender, MouseEventArgs e)
        {
            //如果没有指示要画图，则结束此方法
            if (!beginPaint || drawType == DrawType.spot) return;   //画点不响应Up事件
            if (drawType!=DrawType.curve && drawType != DrawType.eraser)   //当画图类型不是曲线以及橡皮檫时 才需要用到originalImage来接受中间图层的图片后传给目标图层
            {
                interImage = new Bitmap(picBoxtarget.Width, picBoxtarget.Height);  //每次鼠标抬起 清空中间图像
                picboxInter.Image = interImage;
                targetGraphics.DrawImage(originalImage, 0, 0);
                picBoxtarget.Image = targetImage;
            }
            beginMove = false;
        }

        private void btnSize_Click(object sender, EventArgs e)
        {
            UIButton btn = sender as UIButton;
            btnSize1.FillColor = Color.Black;
            btnSize2.FillColor = Color.Black;
            btnSize3.FillColor = Color.Black;
            btnSize4.FillColor = Color.Black;
            switch (btn.Tag.ToString())
            {
                case "2px":
                    myPen.Width = 2;
                    btnSize1.FillColor = btnSize1.FillHoverColor;
                    break;
                case "4px":
                    myPen.Width = 4;
                    btnSize2.FillColor = btnSize1.FillHoverColor;
                    break;
                case "6px":
                    myPen.Width = 6;
                    btnSize3.FillColor = btnSize1.FillHoverColor;
                    break;
                case "8px":
                    myPen.Width = 8;
                    btnSize4.FillColor = btnSize1.FillHoverColor;
                    break;
                default:
                    break;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //清除目标画板的图像
            targetImage = new Bitmap(picBoxtarget.Width, picBoxtarget.Height);
            picBoxtarget.Image = null;
            targetGraphics = Graphics.FromImage(targetImage);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("是否要保存文件", "系统提示", MessageBoxButtons.YesNoCancel);
            if (dialogResult == DialogResult.Yes)//选择先保存
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "JPG|*.jpg;*.jpeg;*.jpe;*.jfif|GIF|*.gif|PNG|*.png|TIF|*.tif;*.tiff";  //"JPG|*.jpg;*.jpeg;*.jpe;*.jfif|GIF|*.gif|PNG|*.png|TIF|*.tif;*.tiff|ICO|*.ico|所有文件|*.*"
                if (saveFile.ShowDialog() == DialogResult.OK)//文件夹显示成功
                {
                    var sFilename = saveFile.FileName;
                    picBoxtarget.Image.Save(sFilename);
                }
            }
            else if (dialogResult == DialogResult.Cancel)//取消则什么都不做直接返回
            {
                return;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (picBoxtarget.Image == null) return;
            if (MessageBox.Show("窗口关闭后，数据将丢失！是否现在关闭窗口","提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel = true;      //取消关闭窗体事件
                return;
            }
        }
    }
}
