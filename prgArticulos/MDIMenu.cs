﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modelo;

namespace prgArticulos
{
    public partial class mdiMenu : Form
    {
        clsConexionSQL conexion;
   
        public mdiMenu(clsConexionSQL conexion)
        {
            this.conexion = conexion;
            InitializeComponent();

        }

      

        private void MDIMenu_Load(object sender, EventArgs e)
        {

        }

        private void mantenimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmUsuario usuarios = new frmUsuario();


        }
    }
}
