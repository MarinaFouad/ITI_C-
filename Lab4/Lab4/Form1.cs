using System.Drawing.Drawing2D;
namespace Lab4
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


        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DisplayString();
            DisplayLine();


        }
        public void DisplayString()
        {
            Graphics graph = this.CreateGraphics();
            graph.DrawString(Lab_Text, Lab_TextFont, Lab_TextBrush, Lab_TextLocation);

        }

        public void DisplayLine()
        {
            Graphics graph = this.CreateGraphics();
            graph.DrawLine(Lab_LinePen, Lab_StartPoint, Lab_EndPoint);

        }

        

        
    }
}
