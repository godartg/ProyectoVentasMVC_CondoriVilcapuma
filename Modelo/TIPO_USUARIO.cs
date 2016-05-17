namespace Modelo
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Linq;

    public partial class TIPO_USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TIPO_USUARIO()
        {
            USUARIO = new HashSet<USUARIO>();
        }

        [Key]
        public int IDTIPOUSUARIO { get; set; }

        [StringLength(20)]
        public string NOMBRE { get; set; }

        [StringLength(1)]
        public string ESTADO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<USUARIO> USUARIO { get; set; }

        public List<TIPO_USUARIO> Listar() //retornar es una coleccion
        {
            var tipousuario = new List<TIPO_USUARIO>();

            try
            {
                using (var db = new db_ventas())
                {
                    tipousuario = db.TIPO_USUARIO.ToList();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return tipousuario;
        }


        public TIPO_USUARIO Obtener(int id) //retornar es un objeto
        {
            var tipousuario = new TIPO_USUARIO();

            try
            {
                using (var db = new db_ventas())
                {
                    tipousuario = db.TIPO_USUARIO.Include("USUARIO")
                                 //.Include("PRODUCTO.NOMBRE")
                                 .Where(x => x.IDTIPOUSUARIO == id)
                                 .SingleOrDefault();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
            return tipousuario;
        }
    }
}
