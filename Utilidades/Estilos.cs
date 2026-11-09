using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FixedSegurosApp.Utilidades
{
    // Acá junto los colores, las letras y el estilo de los controles, sacados de la guía visual
    // (Fixed_Seguros_WinForms.pdf). Cada pantalla llama a estos métodos en su Load, así si quiero
    // cambiar un color lo cambio en un solo lugar.
    internal class Estilos
    {
        // ---------- Paleta ----------
        // static readonly: se crean una sola vez y no se pueden cambiar después
        public static readonly Color NavyPrincipal = Color.FromArgb(27, 58, 92);    // barra lateral y encabezados
        public static readonly Color NavyOscuro = Color.FromArgb(18, 38, 63);       // ítem del menú seleccionado
        public static readonly Color Teal = Color.FromArgb(22, 127, 123);           // botones principales
        public static readonly Color TealHover = Color.FromArgb(15, 102, 99);       // botón principal con el mouse encima
        public static readonly Color Fondo = Color.FromArgb(243, 246, 250);         // fondo de los forms
        public static readonly Color Superficie = Color.White;                      // tarjetas, grillas y campos
        public static readonly Color Borde = Color.FromArgb(213, 221, 232);         // líneas y bordes
        public static readonly Color Texto = Color.FromArgb(30, 42, 56);            // texto general
        public static readonly Color TextoSecundario = Color.FromArgb(91, 107, 127); // etiquetas y pie
        public static readonly Color Exito = Color.FromArgb(46, 125, 79);           // aprobado, pagada, activo
        public static readonly Color Advertencia = Color.FromArgb(154, 103, 0);     // pendiente, por vencer
        public static readonly Color Peligro = Color.FromArgb(192, 57, 43);         // rechazado, impaga, eliminar
        public static readonly Color Informacion = Color.FromArgb(47, 111, 176);    // en evaluación, avisos

        // ---------- Fuentes ----------
        public static readonly Font Normal = new Font("Segoe UI", 9F);
        public static readonly Font Negrita = new Font("Segoe UI", 9F, FontStyle.Bold);
        public static readonly Font Titulo = new Font("Segoe UI Semibold", 16F);

        // ---------- Botones (alto 32px, planos) ----------
        // Los hago planos (FlatStyle.Flat) porque el estilo normal de Windows no deja cambiar el color de fondo

        // Botón verde: Guardar, Ingresar, Nuevo...
        public static void BotonPrincipal(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = TealHover;   // se oscurece al pasar el mouse
            btn.BackColor = Teal;
            btn.ForeColor = Color.White;
            btn.Font = Negrita;
            btn.Cursor = Cursors.Hand;
        }

        // Botón blanco con borde azul: Cancelar, Descartar, Registrarme...
        public static void BotonSecundario(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 1;
            btn.FlatAppearance.BorderColor = NavyPrincipal;
            btn.FlatAppearance.MouseOverBackColor = Fondo;
            btn.BackColor = Superficie;
            btn.ForeColor = NavyPrincipal;
            btn.Font = Negrita;
            btn.Cursor = Cursors.Hand;
        }

        // Botón blanco con borde rojo: Eliminar, Dar de baja... Uso el secundario y le cambio el color
        public static void BotonPeligro(Button btn)
        {
            BotonSecundario(btn);
            btn.FlatAppearance.BorderColor = Peligro;
            btn.ForeColor = Peligro;
        }

        // Botones del menú lateral: texto a la izquierda con un margen
        public static void BotonMenu(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = NavyOscuro;
            btn.BackColor = NavyPrincipal;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F);
            btn.TextAlign = ContentAlignment.MiddleLeft;
            btn.Padding = new Padding(24, 0, 0, 0);
            btn.Cursor = Cursors.Hand;
        }

        // ---------- Grillas (encabezado azul, texto blanco, filas alternadas) ----------
        public static void Grilla(DataGridView dgv)
        {
            // solo para mirar: no se agregan, borran ni editan filas desde la grilla
            dgv.BackgroundColor = Superficie;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Borde;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.MultiSelect = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.RowTemplate.Height = 40;

            // sin esto Windows ignora los colores del encabezado
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.ColumnHeadersHeight = 44;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = NavyPrincipal;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = NavyPrincipal;
            dgv.ColumnHeadersDefaultCellStyle.Font = Negrita;

            dgv.DefaultCellStyle.Font = Normal;
            dgv.DefaultCellStyle.ForeColor = Texto;
            dgv.DefaultCellStyle.SelectionBackColor = NavyPrincipal;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Fondo;
        }

        // ---------- Tarjetas: panel blanco con borde gris claro ----------
        public static void Tarjeta(Panel pnl)
        {
            pnl.BackColor = Superficie;

            // el evento Paint se ejecuta cada vez que Windows redibuja el panel: ahí le dibujo el borde
            pnl.Paint += (sender, e) =>
            {
                Panel p = (Panel)sender;
                e.Graphics.DrawRectangle(new Pen(Borde), 0, 0, p.Width - 1, p.Height - 1);
            };
        }

        // ---------- Gráficos de Reportes: un eje, grilla suave y sin leyenda ----------
        public static void Grafico(Chart chart)
        {
            // el ChartArea es la zona donde se dibujan las barras y los ejes
            ChartArea area = new ChartArea();

            area.BackColor = Superficie;
            area.AxisX.LineColor = Borde;
            area.AxisX.MajorGrid.Enabled = false;          // sin líneas verticales
            area.AxisX.MajorTickMark.Enabled = false;
            area.AxisX.LabelStyle.Font = Normal;
            area.AxisX.LabelStyle.ForeColor = TextoSecundario;
            area.AxisY.LineColor = Color.Transparent;
            area.AxisY.MajorGrid.LineColor = Borde;        // líneas horizontales suaves
            area.AxisY.MajorTickMark.Enabled = false;
            area.AxisY.LabelStyle.Font = Normal;
            area.AxisY.LabelStyle.ForeColor = TextoSecundario;

            chart.BackColor = Superficie;
            chart.BorderlineColor = Borde;
            chart.BorderlineDashStyle = ChartDashStyle.Solid;
            chart.ChartAreas.Add(area);

            // le dejo un título vacío arriba; después Reportes le pone el texto
            chart.Titles.Add(new Title("", Docking.Top, Negrita, NavyPrincipal));
        }

        // ---------- Color del texto de cada estado (para grillas y etiquetas) ----------
        public static Color ColorEstado(string estado)
        {
            switch (estado)
            {
                case "Activo":
                case "Activa":
                case "Habilitado":
                case "Vigente":
                case "Aprobado":
                case "Pagada":
                case "VTV vigente":
                    return Exito;
                case "Suspendido":
                case "Suspendida":
                case "Por habilitar":
                case "Pendiente":
                case "Por vencer":
                case "Sin liquidar":
                    return Advertencia;
                case "Rechazado":
                case "Vencida":
                case "Cuota impaga":
                case "VTV vencida":
                    return Peligro;
                case "En evaluación":
                case "VTV en revisión":
                case "VTV por revisar":
                case "Ofrecida":
                    return Informacion;
                default:
                    return TextoSecundario;   // Baja, Inactiva, Deshabilitado...
            }
        }

        // ---------- Ventanas secundarias ----------

        // Con ControlBox = false Windows descuenta el borde y el espacio de adentro queda más chico.
        // Lo llamo en el Load de las ventanas que tienen controles en posición fija para dejarles el tamaño justo.
        public static void AjustarVentana(Form ventana, int ancho, int alto)
        {
            ventana.Size += new Size(ancho - ventana.ClientSize.Width, alto - ventana.ClientSize.Height);
        }

        // ---------- Texto de ayuda gris dentro de un TextBox (placeholder) ----------
        // .NET Framework 4.8 no tiene la propiedad PlaceholderText, así que lo armo yo:
        // pongo un Label gris adentro del TextBox y lo escondo cuando el campo tiene algo escrito.
        // El texto de ayuda no forma parte del campo: txt.Text sigue vacío.
        public static void Placeholder(TextBox txt, string texto)
        {
            Label ayuda = new Label();
            ayuda.Text = texto;
            ayuda.Font = txt.Font;
            ayuda.ForeColor = TextoSecundario;
            ayuda.BackColor = txt.BackColor;      // mismo fondo que el campo, así parece escrito adentro
            ayuda.AutoSize = true;
            ayuda.Location = new Point(1, 1);
            ayuda.Cursor = Cursors.IBeam;         // el cursor de escribir, como en el TextBox
            ayuda.Visible = txt.Text == "";

            // si hacen clic sobre el texto de ayuda, el foco pasa al campo para poder escribir
            ayuda.Click += (sender, e) => txt.Focus();

            // cada vez que cambia lo escrito, muestro la ayuda solo si el campo quedó vacío
            txt.TextChanged += (sender, e) => ayuda.Visible = txt.Text == "";

            txt.Controls.Add(ayuda);
        }
    }
}
