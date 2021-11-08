using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;
using CEntidades;
using System.Data;

namespace CReglas
{
    public class CRegMascotas
    {
        CDatMascota odatmascota = new CDatMascota();

        public bool guardar_mascota(CEntMascotas oentmascota)
        {
            return odatmascota.guardar_mascota(oentmascota);
        }
        public bool anular_mascota(CEntMascotas oentmascota)
        {
            return odatmascota.anular_mascota(oentmascota);
        }
        public DataSet consultar_mascota(CEntMascotas oentmascota)
        {
            return odatmascota.consultar_mascota(oentmascota);
        }
    }
}
