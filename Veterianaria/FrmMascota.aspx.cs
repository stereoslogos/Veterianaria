using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using CEntidades;
using CReglas;
using System.Windows.Forms;

namespace Veterianaria
{
    public partial class FrmMascota : System.Web.UI.Page
    {
        CEntMascotas oentmascotas = new CEntMascotas();
        CRegMascotas oregmascotas = new CRegMascotas();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (txtIDMascota.Text.Trim() == "")
            {
                LblMensaje.Text = "Digite un ID";
                txtIDMascota.Focus();
            }
            else
            {
                DataSet ds = new DataSet();
                oentmascotas.Cod_mascota = txtIDMascota.Text;
                ds = oregmascotas.consultar_mascota(oentmascotas);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    LblMensaje.Text = "Mascota no registrada";
                    txtIDMascota.Enabled = true;
                    txtIDMascota.Focus();
                    BtnConsulta.Enabled = true;
                }
                else
                {
                    LblMensaje.Text = "";
                    txtIDMascota.Text = ds.Tables[0].Rows[0]["cod_mascota"].ToString();
                    txtNomMascota.Text = ds.Tables[0].Rows[0]["nom_mascota"].ToString();
                }
            }
        }
    }
}