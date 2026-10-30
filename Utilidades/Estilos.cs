using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace FixedSegurosApp.Utilidades
{
    // Colores, fuentes y estilos de la guia visual (Fixed_Seguros_WinForms.pdf)
    internal class Estilos
    {
        // ---------- Paleta ----------
        public static readonly Color NavyPrincipal = Color.FromArgb(27, 58, 92);    // barra lateral y encabezados
        public static readonly Color NavyOscuro = Color.FromArgb(18, 38, 63);       // item de menu seleccionado
        public static readonly Color Teal = Color.FromArgb(22, 127, 123);           // botones principales
        public static readonly Color TealHover = Color.FromArgb(15, 102, 99);       // boton principal con el mouse encima
        public static readonly Color Fondo = Color.FromArgb(243, 246, 250);         // fondo de los forms
        public static readonly Color Superficie = Color.White;                      // tarjetas, grillas y campos
        public static readonly Color Borde = Color.FromArgb(213, 221, 232);         // lineas y bordes
        public static readonly Color Texto = Color.FromArgb(30, 42, 56);            // texto general
        public static readonly Color TextoSecundario = Color.FromArgb(91, 107, 127); // etiquetas y pie
        public static readonly Color Exito = Color.FromArgb(46, 125, 79);           // aprobado, pagada, activo
        public static readonly Color Advertencia = Color.FromArgb(154, 103, 0);     // pendiente, por vencer
        public static readonly Color Peligro = Color.FromArgb(192, 57, 43);         // rechazado, impaga, eliminar
        public static readonly Color Informacion = Color.FromArgb(47, 111, 176);    // en evaluacion, avisos

        // ---------- Fuentes ----------
        public static readonly Font Normal = new Font("Segoe UI", 9F);
        public static readonly Font Negrita = new Font("Segoe UI", 9F, FontStyle.Bold);
        public static readonly Font Titulo = new Font("Segoe UI Semibold", 16F);

        // ---------- Botones (alto 32px, Flat, sin borde) ----------

        // Boton verde: Guardar, Ingresar, Nuevo...
        public static void BotonPrincipal(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = TealHover;
            btn.BackColor = Teal;
            btn.ForeColor = Color.White;
            btn.Font = Negrita;
            btn.Cursor = Cursors.Hand;
        }

        // Boton blanco con borde navy: Cancelar, Descartar, Registrarme...
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

        // Boton blanco con borde rojo: Eliminar, Dar de baja...
        public static void BotonPeligro(Button btn)
        {
            BotonSecundario(btn);
            btn.FlatAppearance.BorderColor = Peligro;
            btn.ForeColor = Peligro;
        }

        // Boton del menu lateral
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

        // ---------- Grillas (encabezado navy, texto blanco) ----------
        public static void Grilla(DataGridView dgv)
        {
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
            pnl.Paint += (sender, e) =>
            {
                Panel p = (Panel)sender;
                e.Graphics.DrawRectangle(new Pen(Borde), 0, 0, p.Width - 1, p.Height - 1);
            };
        }

        // ---------- Color del texto de cada estado (para las grillas) ----------
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
                case "Ofrecida":
                    return Informacion;
                default:
                    return TextoSecundario;   // Baja, Inactiva, Deshabilitado...
            }
        }

        // ---------- Texto de ayuda gris dentro de un TextBox ----------
        // .NET Framework no trae PlaceholderText, por eso se le pide a Windows que lo muestre.
        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        public static void Placeholder(TextBox txt, string texto)
        {
            const int EM_SETCUEBANNER = 0x1501;
            SendMessage(txt.Handle, EM_SETCUEBANNER, (IntPtr)1, texto);   // 1 = se ve aunque el campo tenga el foco
        }
    }
}
