namespace Lab5
{
    public partial class Form1 : Form
    {
        string Lab_Text;
        Font Lab_TextFont;
        Brush Lab_TextBrush;
        Color Lab_TextColor;
        PointF Lab_TextLocation;

        Pen Lab_LinePen;
        Color Lab_LinePenColor;
        Point Lab_StartPoint;
        Point Lab_EndPoint;


        string XY_Text;
        Font XY_TextFont;
        Brush XY_TextBrush;
        Color XY_TextColor;
        PointF XY_TextLocation;
        public Form1()
        {
            InitializeComponent();
            Lab_Text = "Full stack .net track";
            Lab_TextFont = new Font("Times New Roman", 20);
            Lab_TextColor = Color.Black;
            Lab_TextBrush = new SolidBrush(Lab_TextColor);
            Lab_TextLocation = new PointF(100, 100);

            Lab_LinePenColor = Color.Blue;
            Lab_LinePen = new Pen(Lab_LinePenColor, 3);
            Lab_StartPoint = new Point(100, 150);
            Lab_EndPoint = new Point(400, 150);

            XY_TextFont = new Font("Times New Roman", 20);
            XY_TextColor = Color.Black;
            XY_TextBrush = new SolidBrush(XY_TextColor);
            XY_TextLocation = new PointF(0, 0);



        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DisplayString();
            DisplayLine();
            DisplayXY();

        }
        public void DisplayString()
        {
            Graphics graph = this.CreateGraphics();
            graph.DrawString(Lab_Text, Lab_TextFont, Lab_TextBrush, Lab_TextLocation);

        }

        public void DisplayXY()
        {
            Graphics graph = this.CreateGraphics();
            graph.DrawString(XY_Text, XY_TextFont, XY_TextBrush, XY_TextLocation);

        }

        public void DisplayLine()
        {
            Graphics graph = this.CreateGraphics();
            graph.DrawLine(Lab_LinePen, Lab_StartPoint, Lab_EndPoint);

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {

            XY_Text = $"X= {e.X} , Y= {e.Y}";
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.L:
                    Lab_TextColor = Color.Red;
                    break;
                case Keys.B:
                    Lab_TextColor = Color.Purple;
                    break;
                case Keys.X:
                    Lab_TextColor = Color.Aqua;
                    break;
                default:
                    Lab_TextColor = Color.Brown;
                    break;

            }
            
            Lab_TextBrush = new SolidBrush(Lab_TextColor);
            Invalidate();

        }
    }
}
