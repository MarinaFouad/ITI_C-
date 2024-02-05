namespace Lab6
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
            Lab_TextBrush = new SolidBrush(Lab_TextColor);
            graph.DrawString(Lab_Text, Lab_TextFont, Lab_TextBrush, Lab_TextLocation);

        }


        public void DisplayLine()
        {
            Graphics graph = this.CreateGraphics();
            graph.DrawLine(Lab_LinePen, Lab_StartPoint, Lab_EndPoint);

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Dialogbox DB1 = new Dialogbox();
            DB1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult DB2 = colorDialog1.ShowDialog();
            if (DB2 == DialogResult.OK)
            {
                Lab_TextColor = colorDialog1.Color;
                Invalidate();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult DB3 = fontDialog1.ShowDialog();
            if (DB3 == DialogResult.OK)
            {
                Lab_TextFont = fontDialog1.Font;
                Invalidate();
            }
        }
    }
}
