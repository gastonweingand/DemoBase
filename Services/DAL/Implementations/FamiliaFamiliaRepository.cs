using Services.DAL.Contracts;
using Services.DAL.Tools;
using Services.DomainModel.Security.Composite;
using Services.Services.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Services.DAL.Implementations
{

    public sealed class FamiliaFamiliaRepository : IJoinRepository<Familia>
    {
        #region Singleton
        private readonly static FamiliaFamiliaRepository _instance = new FamiliaFamiliaRepository();

        public static FamiliaFamiliaRepository Current
        {
            get
            {
                return _instance;
            }
        }

        private FamiliaFamiliaRepository()
        {
            //Implement here the initialization code
        }
        #endregion
        public void Add(Familia obj)
        {
            foreach (var item in obj.GetChildrens())
            {
                //Verificar si los hijos son familia o patente...
                //Familia_Familia_Insert
                if(item.ChildrenCount() > 0)
                {

                }

            }
        }

        public void Delete(Familia obj)
        {
            //Ejecutar el sp Familia_Familia_DeleteParticular

            throw new NotImplementedException();
        }

        public void GetChildren(Familia obj)
        {
            //1) Buscar en SP Familia_Familia_SelectParticular y retornar id de familias relacionados
            //2) Iterar sobre esos ids -> LLamar al Adaptador y cargar las familias...

            Familia familiaGet = null;

            try
            {
                using (var reader = SqlHelper.ExecuteReader("Familia_Familia_SelectParticular", 
                                                        System.Data.CommandType.StoredProcedure,
                                                        new SqlParameter[] {new SqlParameter("@IdFamilia", obj.IdComponent) }))
                {
                    object[] values = new object[reader.FieldCount];

                    while (reader.Read())
                    {
                        reader.GetValues(values);
                        //Obtengo el id de familia relacionado a la familia principal...(obj)
                        Guid idFamiliaHija = Guid.Parse(values[1].ToString());

                        familiaGet = FamiliaRepository.Current.SelectOne(idFamiliaHija);

                        obj.Add(familiaGet);
                    }
                }
            }
            catch (Exception ex)
            {
                ex.Handle(this);
            }
        }
    }
}
