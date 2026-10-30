using FixedSegurosApp.Negocio;
using FixedSegurosApp.Utilidades;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace FixedSegurosApp.Vistas
{
    // Arma los casilleros de fotos del vehículo (4 arriba y el resto abajo, cada uno con su nombre).
    // Se usa en "Mis vehículos" y en "Detalle del cliente".
    internal class GrillaFotos
    {
        // Nombres cortos para mostrar debajo de cada casillero (mismo orden que VehiculoNegocio.Posiciones)
        public static readonly string[] Nombres =
        {
            "Frente", "Atrás", "Lat. izquierdo", "Lat. derecho", "Baúl", "Int. delantero", "Motor"
        };

        // Crea los casilleros dentro de "contenedor" a partir de (x, y) y los devuelve en orden.
        // Cada casillero guarda en Tag su número (0 a 6) para saber cuál se tocó en el evento Click.
        public static PictureBox[] Crear(Control contenedor, int x, int y, int ancho, int alto, EventHandler alHacerClic)
        {
            PictureBox[] casilleros = new PictureBox[Nombres.Length];

            for (int i = 0; i < Nombres.Length; i++)
            {
                int fila = i / 4;
                int columna = i % 4;
                int posX = x + columna * (ancho + 6);
                int posY = y + fila * (alto + 22);

                PictureBox casillero = new PictureBox();
                casillero.Location = new Point(posX, posY);
                casillero.Size = new Size(ancho, alto);
                casillero.BackColor = Estilos.Fondo;
                casillero.BorderStyle = BorderStyle.FixedSingle;
                casillero.SizeMode = PictureBoxSizeMode.Zoom;
                casillero.Cursor = Cursors.Hand;
                casillero.Tag = i;
                casillero.Click += alHacerClic;

                Label nombre = new Label();
                nombre.Name = "lbl_foto_" + i;
                nombre.Text = Nombres[i];
                nombre.Location = new Point(posX, posY + alto + 2);
                nombre.Size = new Size(ancho, 16);
                nombre.TextAlign = ContentAlignment.TopCenter;
                nombre.Font = new Font("Segoe UI", 8F);
                nombre.ForeColor = Estilos.TextoSecundario;

                contenedor.Controls.Add(casillero);
                contenedor.Controls.Add(nombre);
                casilleros[i] = casillero;
            }

            return casilleros;
        }

        // Deja visibles solo las fotos que lleva ese tipo de vehículo y las acomoda sin dejar huecos.
        public static void Mostrar(PictureBox[] casilleros, string tipoVehiculo)
        {
            string[] posiciones = VehiculoNegocio.PosicionesDe(tipoVehiculo);
            int visibles = 0;

            for (int i = 0; i < casilleros.Length; i++)
            {
                PictureBox casillero = casilleros[i];
                Label nombre = (Label)casillero.Parent.Controls["lbl_foto_" + i];
                bool visible = Array.IndexOf(posiciones, VehiculoNegocio.Posiciones[i]) >= 0;

                casillero.Visible = visible;
                nombre.Visible = visible;

                if (visible)
                {
                    casillero.Left = casilleros[0].Left + (visibles % 4) * (casillero.Width + 6);
                    casillero.Top = casilleros[0].Top + (visibles / 4) * (casillero.Height + 22);
                    nombre.Left = casillero.Left;
                    nombre.Top = casillero.Bottom + 2;
                    visibles++;
                }
            }
        }
    }
}
