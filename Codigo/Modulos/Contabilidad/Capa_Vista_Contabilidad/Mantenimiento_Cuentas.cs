using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista_Contabilidad
{
    public partial class Mantenimiento_Cuentas : Form
    {
        public Mantenimiento_Cuentas()
        {
            InitializeComponent();

            string idusuario = Interfac_V3.UsuarioSesion.GetIdUsuario();

            string[] alias = { "Codigo", "TipoCuenta", "Grupo cuenta", "Nombre", "Cargo-Mes", "Abono-Mes", "Saldo-Anterior", "Saldo-Actual", "Cargo-Acumulado", "Abono-Acumulado", "Cuenta-padre", "Efectivo", "Estado" };
            navegador1.AsignarAlias(alias);
            navegador1.AsignarSalida(this);
            navegador1.AsignarColorFondo(Color.FromArgb(242, 133, 122));
            navegador1.AsignarColorFuente(Color.Black);
            navegador1.ObtenerIdAplicacion("8000");
            navegador1.AsignarAyuda("1");
            navegador1.ObtenerIdUsuario(idusuario);
            navegador1.AsignarTabla("tbl_cuentas");
            navegador1.AsignarNombreForm("Cuentas");

            //// Asignar combos para las relaciones foráneas (tipo activo, marca y cuenta contable)
            /*navegador1.AsignarComboConTabla("tbl_tipoactivofijo", "Pk_Id_TipoActivoFijo", "Nombre_Tipo", 1);
            navegador1.AsignarComboConTabla("tbl_identidadactivo", "Pk_Id_Identidad", "Nombre_Identidad", 1);
            navegador1.AsignarComboConTabla("tbl_cuentas", "Pk_id_cuenta", "nombre_cuenta", 1); 

            //// Asignar las relaciones foráneas para tipo de activo, marca y cuenta contable
            navegador1.AsignarForaneas("tbl_tipoactivofijo", "Nombre_Tipo", "Pk_Id_TipoActivoFijo", "Pk_Id_TipoActivoFijo");
            navegador1.AsignarForaneas("tbl_identidadactivo", "Nombre_Identidad", "Pk_Id_Identidad", "Pk_Id_Identidad");
            navegador1.AsignarForaneas("tbl_cuentas", "nombre_cuenta", "Pk_id_cuenta", "Pk_id_cuenta"); */
        }
    }
}
