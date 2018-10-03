using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MyCanvas
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Stack<Image> StImage = new Stack<Image>();      // 이미지 스택
        Stack<Image> FoStImage = new Stack<Image>();    //앞으로

        private Point pt1;      // 시작점
        private Point pt2;      // 종료점

        private Point ptb1;      // 베지어 스플라인용도, 삼각형에도 사용
        private Point ptb2;      // 다이아 사용
        private Point ptb3;
        private Point ptb4;

        private Color myColor;      // 그릴때 사용할 색깔에 대한 정보를 가진다.

        int LineSizeNum = 3;
        int StyleNum = 0;

        public void SetColor()
        {
            if (ColorDlg.ShowDialog() == DialogResult.OK)
            {       //대화상자 표시, 색선택, 선택된 색 저장
                myColor = ColorDlg.Color;
            }
            // 컬러 툴바 색 변경
            ColorBtn.BackColor = myColor;
        }

        //어떤 도형을 그릴지에 대한 정보를 가집니다.
        private int DrawMode;

        //어떤 도형을  그릴지 결정하기
        public void SetShape(int i)
        {
            DrawMode = i;
        }

        //도형 번호
        enum Shape : int
        {
            Line,
            Rect,
            Circle,
            FreeLine,
            Text,
            ConverColor,
            DrawBezier,
            DrawTriangle,
            DrawDiamond,
            Eraser
        }

        public void SetData1(int Data)       //SETDATA
        {
            LineSizeNum = Data;
        }

        public void SetData2(int Data)       //SETDATA
        {
            StyleNum = Data;
        }      



        //직선 Draw
        private void DrawLine(Pen myPen, Graphics g)
        {
            g.DrawLine(myPen, pt1, pt2);
        }

        //사각형 Draw
        private void DrawRectangle(Pen myPen, Graphics g)
        {
            int x, y, width, height;

            if (pt1.X <= pt2.X)
            {
                x = pt1.X;
                width = pt2.X - x;
            }
            else
            {
                x = pt2.X;
                width = pt1.X - x;
            }

            if (pt1.Y <= pt2.Y)
            {
                y = pt1.Y;
                height = pt2.Y - y;
            }
            else
            {
                y = pt2.Y;
                height = pt1.Y - y;
            }
            g.DrawRectangle(myPen, x, y, width, height);
        }

        //원 Draw
        private void DrawCicle(Pen myPen, Graphics g)
        {
            int x, y, width, height;

            if (pt1.X <= pt2.X)
            {
                x = pt1.X;
                width = pt2.X - x;
            }
            else
            {
                x = pt2.X;
                width = pt1.X - x;
            }

            if (pt1.Y <= pt2.Y)
            {
                y = pt1.Y;
                height = pt2.Y - y;
            }
            else
            {
                y = pt2.Y;
                height = pt1.Y - y;
            }
            g.DrawEllipse(myPen, x, y, width, height);
        }

        //자유 곡선 Draw
        private void DrawFreeLine(Pen myPen, Graphics g)
        {
            g.DrawLine(myPen, pt1, pt2);
        }

        //베지어 스플라인 Draw
        private void DrawBezier(Pen myPen, Graphics g)
        {
            int x1, x2;

            if (ptb1.X <= ptb4.X)
            {   //ptb2.X
                x1 = ptb1.X;
                x1 = x1 + ((ptb4.X - ptb1.X) / 3);
                ptb2.X = x1;
                //ptb2.Y
                ptb2.Y = ptb1.Y - 180;
                //ptb3.X
                x2 = ptb4.X;
                x2 = x2 - ((ptb4.X - ptb1.X) / 3);
                ptb3.X = x2;
                //ptb2.Y
                ptb3.Y = ptb4.Y + 180;
            }
            else
            {   //ptb2.X
                x1 = ptb1.X;
                x1 = x1 + ((ptb4.X - ptb1.X) / 3);
                ptb2.X = x1;
                //ptb2.Y
                ptb2.Y = ptb1.Y - 180;
                //ptb3.X
                x2 = ptb4.X;
                x2 = x2 - ((ptb4.X - ptb1.X) / 3);
                ptb3.X = x2;
                //ptb2.Y
                ptb3.Y = ptb4.Y + 180;
            }
            g.DrawBezier(myPen, ptb1, ptb2, ptb3, ptb4);
        }

        //삼각형 Draw
        private void DrawTriangle(Pen myPen, Graphics g)
        {       // 역삼각형도 일부러 유도하기 위해(사용하기 위해)
                //pt1, pt2의 방향이 바뀔때는 계산하지 않는다.
            ptb1.X = pt1.X; //점1
            ptb1.Y = pt2.Y;

            ptb2.X = pt2.X; //점2
            ptb2.Y = pt2.Y;

            ptb3.X = ((pt2.X - pt1.X) / 2) + pt1.X; //점3
            ptb3.Y = pt1.Y;

            g.DrawLine(myPen, ptb1, ptb2);
            g.DrawLine(myPen, ptb2, ptb3);
            g.DrawLine(myPen, ptb3, ptb1);
        }

        //다이아몬드 Draw
        private void DrawDiamond(Pen myPen, Graphics g)
        {
            ptb1.X = ((pt2.X - pt1.X) / 2) + pt1.X;
            ptb1.Y = pt1.Y;

            ptb2.X = pt2.X;
            ptb2.Y = ((pt2.Y - pt1.Y) / 2) + pt1.Y;

            ptb3.X = ((pt2.X - pt1.X) / 2) + pt1.X;
            ptb3.Y = pt2.Y;

            ptb4.X = pt1.X;
            ptb4.Y = ((pt2.Y - pt1.Y) / 2) + pt1.Y;

            g.DrawLine(myPen, ptb1, ptb2);
            g.DrawLine(myPen, ptb2, ptb3);
            g.DrawLine(myPen, ptb3, ptb4);
            g.DrawLine(myPen, ptb1, ptb4);
        }

        private void Eraser(Pen EraserPen, Graphics g)
        {
            g.DrawLine(EraserPen, pt1, pt2);
        }

        //도형 그리기 (CASE문)
        private void DrawShape()
        {
            Pen myPen = new Pen(myColor, LineSizeNum);                // myPen
            //myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            if (StyleNum == 1)
            {
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            }
            else if (StyleNum == 2)
            {
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            }
            else if (StyleNum == 3)
            {
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            }
            else if (StyleNum == 4)
            {
                myPen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            }

            Pen EraserPen = new Pen(Color.White, 15);                   // 지우개
            Graphics g = Graphics.FromImage(Canvas.Image);

            switch (DrawMode)
            {
                case (int)Shape.Line:
                    DrawLine(myPen, g);
                    break;
                case (int)Shape.Rect:
                    DrawRectangle(myPen, g);
                    break;
                case (int)Shape.Circle:
                    DrawCicle(myPen, g);
                    break;
                case (int)Shape.FreeLine:
                    DrawFreeLine(myPen, g);
                    break;
                case (int)Shape.Text:
                    Brush myBrush = new SolidBrush(myColor);
                    DrawText(myBrush, g);
                    break;
                case (int)Shape.ConverColor:
                    ConvertColor();
                    break;
                case (int)Shape.DrawBezier:
                    DrawBezier(myPen, g);
                    break;
                case (int)Shape.DrawTriangle:
                    DrawTriangle(myPen, g);
                    break;
                case (int)Shape.DrawDiamond:
                    DrawDiamond(myPen, g);
                    break;
                case (int)Shape.Eraser:
                    Eraser(EraserPen, g);
                    break;
            }
            Canvas.Refresh();
        }

        //Canvas에 출력할 텍스트의 글꼴
        private static Font myfont;
        //Canvas에 출력할 텍스트
        private static string contents;

        //글꼴, myfont에 대한 속성(get, set)
        public static Font myFont
        {
            get
            {
                return myfont;
            }
            set
            {
                myfont = value;
            }
        }
        //출력할 내용, contents에 대한 속성(get, set)
        public static string Contents
        {
            get
            {
                return contents;
            }
            set
            {
                contents = value;
            }
        }

        //텍스트 Draw
        private void DrawText(Brush myBrush, Graphics g)
        {
            TextDlg myTextDlg = new TextDlg();

            //TextDlg 대화상자를 띄워서 글꼴과
            myTextDlg.ShowDialog(this);
            //출력할 내용에 대한 정보를 입력받습니다.
            g.DrawString(Contents, myFont, myBrush, pt2);
            //내용을 출력하고
            Contents = "";      //변수의 내용을 삭제
        }

        private static Color sourcecolor;
        private static Color targetcolor;
        //원본 색상
        public static Color SourceColor
        {
            get
            {
                return sourcecolor;
            }
            set
            {
                sourcecolor = value;
            }
        }
        //대상 색상
        public static Color TargetColor
        {
            get
            {
                return targetcolor;
            }
            set
            {
                targetcolor = value;
            }
        }

        //색상변경
        private void ConvertColor()
        {
            //Canvers.Image를 이용해 bitmap객체를 생성합니다.
            Bitmap tempBMP = new Bitmap(Canvas.Image);

            //마우스로 찍었던 픽셀의 색을 얻어와 SourceColor에 저장합니다.
            Color tempColor = tempBMP.GetPixel(pt2.X, pt2.Y);
            SourceColor = tempColor;

            //COnvertClrDlg를 띄워 targetColor에 바꿀색을 입력받습니다.
            ConvertClrDlg myConvertClrDlg = new ConvertClrDlg();
            myConvertClrDlg.ShowDialog(this);

            //tempBMP의 각 픽셀을 돌면서 SetPixel()을 이용해 색을 바꿉니다.
            for (int i = 0; i < tempBMP.Height; i++)
            {
                for (int j = 0; j < tempBMP.Width; j++)
                {
                    if (tempBMP.GetPixel(j, i) == SourceColor)
                    {
                        tempBMP.SetPixel(j, i, TargetColor);
                    }
                }
            }
            //변경된 tempBMP를 Canvas.Image에 저장합니다.
            Canvas.Image = tempBMP;
        }

        //새로운파일
        public void NewDocument()
        {
            //Cnavas.Image에 이미지가 있다면 저장
            if (Canvas.Image != null)
            {
                SaveDocument();
            }

            //Canvas의 너비와 높이가 같은 Bitmap 객체를 생성
            Bitmap newBitmap = new Bitmap(Canvas.Width, Canvas.Height);
            Canvas.Image = newBitmap;

            //Cnavas를 하얀색으로 칠합니다.
            Brush myBrush = new SolidBrush(Color.White);
            Graphics g = Graphics.FromImage(Canvas.Image);
            g.FillRectangle(myBrush, 0, 0, Canvas.Image.Width, Canvas.Image.Height);

            //사용할 색을 검정색으로 설정합니다.
            myColor = Color.Black;
            ColorBtn.BackColor = myColor;
        }
        //파일열기
        public void OpenDocument()
        {
            try
            {
                if (Canvas.Image != null)
                {
                    SaveDocument();
                }
                if (OpenDlg.ShowDialog() == DialogResult.OK)
                {
                    Canvas.Image = Image.FromFile(OpenDlg.FileName);
                }
            }
            catch (Exception openE)
            {
                //파일을 열 때 예외 상황이 발생하면 예외 내용을 사용자에게 알립니다.
                MessageBox.Show(this, "파일을 여는데 오류가 발생하였습니다. :" + openE.Message, "myCanvas", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //파일저장
        public void SaveDocument()
        {
            //먼저 그림판이 비어있나 검사
            if (Canvas.Image != null)
            {
                //비어있지 않다면 작업중인 문서를 저장합니다.
                if (MessageBox.Show(this, "저장하시겠습니까?", "myCanvas", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //SaveDlg를 띄워 파일 이름을 선택하게 한 후
                    if (SaveDlg.ShowDialog() == DialogResult.OK)
                    {
                        //문서를 저장합니다.
                        Canvas.Image.Save(SaveDlg.FileName);
                    }
                }
            }
        }

        //메뉴 File 이벤트
        private void menu_File_New_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void menu_File_Open_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void menu_File_Save_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void menu_Exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(this, "종료하시겠습니까?", "myCanvas", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            NewDocument();
        }

        //켄버스 마우스 이벤트
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {   
            pt1.X = e.X;
            pt1.Y = e.Y;

            inputImage();

            if (DrawMode == (int)Shape.DrawBezier)
            {
                ptb1.X = e.X;
                ptb1.Y = e.Y;

                inputImage();
            }
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) // 마우스 왼쪽 버튼을 눌렀다면
            {
                //그리기모드가 자유곡선 그리기일때만
                if (DrawMode == (int)Shape.FreeLine)
                {
                    pt2.X = pt1.X;
                    pt2.Y = pt1.Y;
                    pt1.X = e.X;
                    pt1.Y = e.Y;
                    DrawShape();
                }
                else if (DrawMode == (int)Shape.Eraser)
                {
                    pt2.X = pt1.X;
                    pt2.Y = pt1.Y;
                    pt1.X = e.X;
                    pt1.Y = e.Y;
                    DrawShape();
                }
            }
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)        //마우스 UP
        {
            pt2.X = e.X;
            pt2.Y = e.Y;
            if (DrawMode == (int)Shape.DrawBezier)
            {
                ptb4.X = e.X;
                ptb4.Y = e.Y;
            }
            DrawShape();
        }

        //STACK SAVE
        public void inputImage()
        {
            //Image Save
            Image saveImage;
            saveImage = (Image)Canvas.Image.Clone();
            StImage.Push(saveImage);
        }

        //메뉸 Shape 이밴트
        private void menu_Shape_Line_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Line);
        }

        private void menu_Shape_Rect_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Rect);
        }

        private void menu_Shape_Circle_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Circle);
        }

        private void menu_Shape_Free_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.FreeLine);
        }

        private void menu_Shape_Text_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Text);
        }

        private void menu_Shape_Color_Click(object sender, EventArgs e)
        {
            SetColor();
        }

        private void menu_Shape_Convert_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.ConverColor);
        }

        private void menu_help_About_Click(object sender, EventArgs e)
        {
            AboutDlg myAboutDlg = new AboutDlg();
            myAboutDlg.ShowDialog(this);
        }

        private void menu_Shape_Bezier_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.DrawBezier);
        }

        private void menu_Shape_Triangle_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.DrawTriangle);
        }

        private void menu_Shape_Diamond_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.DrawDiamond);
        }

        private void menu_Shape_ConvertLineSize_Click(object sender, EventArgs e)
        {
            LineSizeDlg myLineSize = new LineSizeDlg(this, this);
            myLineSize.ShowDialog();
        }

        private void menu_Shape_Eraser_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Eraser);
        }

        private void serchingImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerchingImageDlg mySerch = new SerchingImageDlg();
            mySerch.ShowDialog();
        }

        //툴바 이벤트
        private void NewBtn_Click(object sender, EventArgs e)
        {
            NewDocument();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            OpenDocument();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SaveDocument();
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Line);
        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Rect);
        }

        private void CircleBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Circle);
        }

        private void FreeBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.FreeLine);
        }

        private void TextBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Text);
        }

        private void ConvertClrBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.ConverColor);
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            SetColor();
        }

        private void BezBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.DrawBezier);
        }

        private void TriBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.DrawTriangle);
        }

        private void DiaBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.DrawDiamond);
        }

        private void LineSizeBtn_Click(object sender, EventArgs e)
        {
            LineSizeDlg myLineSize = new LineSizeDlg(this, this);
            myLineSize.ShowDialog();
        }

        private void eraserBtn_Click(object sender, EventArgs e)
        {
            SetShape((int)Shape.Eraser);
        }

        private void SerchingEmageBtn_Click(object sender, EventArgs e)
        {
            SerchingImageDlg mySerch = new SerchingImageDlg();
            mySerch.ShowDialog();
        }

        private void PrinterBtn_Click(object sender, EventArgs e)
        {
            if(printDialogSet.ShowDialog() == DialogResult.OK)
            {
                printDocumentSet.Print();
            }
        }

        //프린트

        private void printDocumentSet_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(Canvas.Image, 0, 0);
        }

        //뒤로가기

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (StImage.Count() == 0)
            {
                MessageBox.Show("더이상 뒤로 갈 이미지가 없습니다.");
                return;
            }

            Image saveImage;                          //앞으로갈때 사용
            saveImage = (Image)Canvas.Image.Clone();
            FoStImage.Push(saveImage);

            Image saveStImage = StImage.Pop();       // 되돌리기
            Canvas.Image = saveStImage;
            Canvas.Invalidate();
        }

        private void FrontBtn_Click(object sender, EventArgs e)
        {
            if (FoStImage.Count() == 0)
            {
                MessageBox.Show("더이상 앞으로 갈 이미지가 없습니다.");
                return;
            }
                        
            Image saveImage;                            //다시 뒤로갈때 사용
            saveImage = (Image)Canvas.Image.Clone();
            StImage.Push(saveImage);

            Image saveStimage = FoStImage.Pop();        //앞으로
            Canvas.Image = saveStimage;
            Canvas.Invalidate();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Image saveImage;
            saveImage = (Image)Canvas.Image.Clone();
            saveImage.RotateFlip(RotateFlipType.Rotate90FlipNone);
            Canvas.Image = saveImage;
            Canvas.Invalidate();
        }

        // 색상자

        private void redBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Red;
            ColorBtn.BackColor = myColor;
        }

        private void brownBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Brown;
            ColorBtn.BackColor = myColor;
        }

        private void orangeBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Orange;
            ColorBtn.BackColor = myColor;
        }

        private void goldBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Gold;
            ColorBtn.BackColor = myColor;
        }

        private void yellowBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Yellow;
            ColorBtn.BackColor = myColor;
        }

        private void limeBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Lime;
            ColorBtn.BackColor = myColor;
        }

        private void cyanBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Cyan;
            ColorBtn.BackColor = myColor;
        }

        private void oliveBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Olive;
            ColorBtn.BackColor = myColor;
        }

        private void blueBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Blue;
            ColorBtn.BackColor = myColor;
        }

        private void mediumpurpleBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.MediumPurple;
            ColorBtn.BackColor = myColor;
        }

        private void darkbioletBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.DarkViolet;
            ColorBtn.BackColor = myColor;
        }

        private void violetBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Violet;
            ColorBtn.BackColor = myColor;
        }

        private void magentaBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Magenta;
            ColorBtn.BackColor = myColor;
        }

        private void pinkBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Pink;
            ColorBtn.BackColor = myColor;
        }

        private void whiteBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.White;
            ColorBtn.BackColor = myColor;
        }

        private void grayBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Gray;
            ColorBtn.BackColor = myColor;
        }

        private void blackBtn_Click(object sender, EventArgs e)
        {
            myColor = Color.Black;
            ColorBtn.BackColor = myColor;
        }
    }
}
