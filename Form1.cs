namespace pryLopezFirma
{
    public partial class frmFirma : Form
    {
        public frmFirma()
        {
            InitializeComponent();
            InitializeDrawing();
        }
        private Point previousPoint;
        private List<Point> points = new List<Point>();
        private bool isDrawing = false;
        private List<List<Point>> drawings = new List<List<Point>>();
        private List<Point> currentDrawing = new List<Point>();
        private Bitmap drawingBitmap;
        private Bitmap bitmap; // Bitmap utilizado para dibujar en el PictureBox
        private Graphics graphics; // Objeto Graphics para dibujar en el Bitmap
        private void PictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            // Finalizar el dibujo
            isDrawing = false;
        }
        private void PictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            // Iniciar el dibujo y registrar el primer punto
            points.Add(e.Location);
            isDrawing = true;
            previousPoint = e.Location;
        }
        private void InitializeDrawing()
        {
            drawingBitmap = new Bitmap(pctFirma.Width, pctFirma.Height);
            pctFirma.Image = drawingBitmap;
            Graphics.FromImage(drawingBitmap).Clear(Color.White);
        }
        public void PictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            // Si se está dibujando, registrar el punto actual
            if (isDrawing)
            {
                using (Graphics g = Graphics.FromImage(drawingBitmap))
                {
                    g.DrawLine(Pens.Black, previousPoint, e.Location);
                }
                previousPoint = e.Location;
                pctFirma.Invalidate();
                points.Add(e.Location);
                pctFirma.Invalidate(); // Invalidar el PictureBox para forzar un repintado
            }
        }
        private void PictureBox1_Paint(object sender, PaintEventArgs e)
        {
            // Dibujar líneas conectando todos los puntos registrados
            if (points.Count > 1)
            {
                e.Graphics.DrawLines(Pens.Black, points.ToArray());
            }
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            // Obtener la fecha y hora actual
            DateTime ahora = DateTime.Now;

            // Crear el nombre de archivo usando la fecha y hora actual
            string NombreArchivo = $"{ahora:yyyyMMdd_HHmmss}.png"; // Puedes cambiar la extensión según el tipo de imagen

            // Directorio donde se guardarán las imágenes
            string Directorio = @"C:\Users\santi\source\repos\pryLopezFirma\FIRMAS"; // Reemplaza con la ruta de tu carpeta

            // Comprobar si el directorio existe, si no, crearlo
            if (!Directory.Exists(Directorio))
            {
                Directory.CreateDirectory(Directorio);
            }

            // Combinar el directorio con el nombre de archivo para obtener la ruta completa
            string fullPath = Path.Combine(Directorio, NombreArchivo);

            try
            {
                // Guardar la imagen (asumiendo que tienes un objeto de imagen llamado 'drawingBitmap' por ejemplo)
                drawingBitmap.Save(fullPath, System.Drawing.Imaging.ImageFormat.Png);

                MessageBox.Show("La imagen se ha guardado correctamente en la carpeta 'FIRMAS'.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar la imagen: {ex.Message}");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Borra el dibujo actual creando un nuevo Bitmap y asignándolo al PictureBox
            bitmap = new Bitmap(pctFirma.Width, pctFirma.Height); // Crea un nuevo Bitmap vacío
            graphics = Graphics.FromImage(bitmap); // Inicializa el objeto Graphics con el nuevo Bitmap
            graphics.Clear(Color.White); // Limpia el bitmap con un color de fondo blanco
            pctFirma.Image = bitmap; // Asigna el nuevo Bitmap al PictureBox
            InitializeDrawing();
        }
    }
}
